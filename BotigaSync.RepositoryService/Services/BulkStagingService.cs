using System.Data;
using System.Text.Json;
using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;
using BotigaSync.Repository.MasterData;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BotigaSync.RepositoryService.Services;

// Deliberately does not touch SyncEventService or anything it depends on - a separate
// code path for the staging-table backfill approach. No GlobalId resolution, no
// reference fix-up, no business logic at all here - that all happens afterward via plain
// SQL run directly against botiga_master, once a table's data is fully landed in stg.
public sealed class BulkStagingService(MasterBotigaDataContext master) : IBulkStagingService
{
    public async Task<BulkStagingResponse> InsertRowsAsync(string tableName, BulkStagingRequest request, CancellationToken cancellationToken)
    {
        if (request.Rows.Count == 0)
        {
            return new BulkStagingResponse { Success = true, RowsInserted = 0 };
        }

        var connection = (SqlConnection)master.Database.GetDbConnection();
        var wasClosed = connection.State != ConnectionState.Open;
        if (wasClosed)
        {
            await connection.OpenAsync(cancellationToken);
        }

        try
        {
            // Restricted to TABLE_SCHEMA = 'stg' on purpose - this endpoint does zero
            // validation or business logic, so it must never be able to write into dbo.*
            // (that's the real, constraint-checked, RLS-protected schema live sync and the
            // resolve-and-apply relay logic both write to). tableName is only ever used
            // below after being confirmed to match a real stg.* table by this parameterized
            // lookup, so it's safe to interpolate into the bulk copy destination afterward.
            var columns = new List<(string Name, string DataType)>();
            await using (var cmd = new SqlCommand(
                "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_SCHEMA = 'stg' AND TABLE_NAME = @TableName ORDER BY ORDINAL_POSITION", connection))
            {
                cmd.Parameters.AddWithValue("@TableName", tableName);
                await using var reader = await cmd.ExecuteReaderAsync(cancellationToken);
                while (await reader.ReadAsync(cancellationToken))
                {
                    columns.Add((reader.GetString(0), reader.GetString(1)));
                }
            }

            if (columns.Count == 0)
            {
                return new BulkStagingResponse
                {
                    Success = false,
                    ErrorMessage = $"stg.{tableName} does not exist. Create it first - it isn't auto-created here."
                };
            }

            var hasBatchId = columns.Any(c => c.Name.Equals("BatchId", StringComparison.OrdinalIgnoreCase));
            if (hasBatchId && request.BatchId != Guid.Empty)
            {
                await using var dupCheck = new SqlCommand(
                    $"SELECT TOP 1 1 FROM stg.[{tableName}] WHERE BatchId = @BatchId", connection);
                dupCheck.Parameters.AddWithValue("@BatchId", request.BatchId);
                var alreadyProcessed = await dupCheck.ExecuteScalarAsync(cancellationToken) != null;
                if (alreadyProcessed)
                {
                    return new BulkStagingResponse { Success = true, Duplicate = true, RowsInserted = 0 };
                }
            }

            var table = new DataTable();
            foreach (var column in columns)
            {
                table.Columns.Add(column.Name, MapSqlTypeToClr(column.DataType));
            }

            // --storeId always wins here too, same rule as the backfill tool's own
            // ApplyStoreId - if the staging table has a StoreId column, every row gets the
            // target store's id regardless of whatever local value the payload carries.
            var hasStoreId = columns.Any(c => c.Name.Equals("StoreId", StringComparison.OrdinalIgnoreCase));

            foreach (var row in request.Rows)
            {
                var dataRow = table.NewRow();
                foreach (var column in columns)
                {
                    if (hasStoreId && column.Name.Equals("StoreId", StringComparison.OrdinalIgnoreCase))
                    {
                        dataRow[column.Name] = request.StoreId;
                        continue;
                    }

                    if (hasBatchId && column.Name.Equals("BatchId", StringComparison.OrdinalIgnoreCase))
                    {
                        dataRow[column.Name] = request.BatchId == Guid.Empty ? DBNull.Value : request.BatchId;
                        continue;
                    }

                    if (!row.TryGetValue(column.Name, out var element)
                        || element.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined)
                    {
                        dataRow[column.Name] = DBNull.Value;
                        continue;
                    }

                    dataRow[column.Name] = ConvertJsonElement(element, table.Columns[column.Name]!.DataType);
                }

                table.Rows.Add(dataRow);
            }

            using var bulkCopy = new SqlBulkCopy(connection)
            {
                DestinationTableName = $"stg.[{tableName}]",
                BulkCopyTimeout = 300
            };
            foreach (DataColumn column in table.Columns)
            {
                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
            }

            await bulkCopy.WriteToServerAsync(table, cancellationToken);

            return new BulkStagingResponse { Success = true, RowsInserted = table.Rows.Count };
        }
        finally
        {
            if (wasClosed)
            {
                await connection.CloseAsync();
            }
        }
    }

    private static Type MapSqlTypeToClr(string sqlDataType) => sqlDataType switch
    {
        "int" => typeof(int),
        "bigint" => typeof(long),
        "smallint" => typeof(short),
        "tinyint" => typeof(byte),
        "bit" => typeof(bool),
        "decimal" or "numeric" or "money" or "smallmoney" => typeof(decimal),
        "float" => typeof(double),
        "real" => typeof(float),
        "uniqueidentifier" => typeof(Guid),
        "datetime" or "datetime2" or "smalldatetime" or "date" => typeof(DateTime),
        _ => typeof(string)
    };

    private static object ConvertJsonElement(JsonElement element, Type targetType)
    {
        if (targetType == typeof(Guid))
        {
            return element.ValueKind == JsonValueKind.String && Guid.TryParse(element.GetString(), out var guid)
                ? guid
                : DBNull.Value;
        }

        if (targetType == typeof(DateTime))
        {
            return element.TryGetDateTime(out var dateTime) ? dateTime : DBNull.Value;
        }

        if (targetType == typeof(bool))
        {
            return element.ValueKind switch
            {
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                JsonValueKind.Number => element.GetInt32() != 0,
                _ => DBNull.Value
            };
        }

        return JsonSerializer.Deserialize(element.GetRawText(), targetType) ?? (object)DBNull.Value;
    }
}
