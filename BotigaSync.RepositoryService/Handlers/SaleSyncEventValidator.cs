using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;

namespace BotigaSync.RepositoryService.Handlers;

/// <summary>
/// Validates the aggregate produced by the POS sale outbox.  The generic applier
/// remains responsible for persisting records and resolving their references.
/// </summary>
public sealed class SaleSyncEventValidator : ISyncEventValidator
{
    private static readonly HashSet<string> SupportedEvents = new(StringComparer.OrdinalIgnoreCase)
    {
        "SaleCompleted",
        "SaleHeld",
        "SaleVoided"
    };

    private static readonly HashSet<string> AllowedEntities = new(StringComparer.OrdinalIgnoreCase)
    {
        "InvoiceTotal",
        "InvoiceItem",
        "MoneyActivity",
        "CCTrans",
        "InventoryTransaction",
        "GiftCardTransaction",
        "RewardPointsTransaction",
        "OnAccountTransaction",
        "OnAccountTransactionDetail",
        "InvoiceException",
        "InvoiceOnHold"
    };

    public bool CanValidate(string eventType) => SupportedEvents.Contains(eventType);

    public void Validate(SyncEventEnvelope envelope)
    {
        if (!envelope.AggregateType.Equals("InvoiceTotal", StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException($"{envelope.EventType} must use InvoiceTotal as its aggregate.");
        }

        var invoice = envelope.Records.SingleOrDefault(record =>
            record.EntityType.Equals("InvoiceTotal", StringComparison.OrdinalIgnoreCase) &&
            record.GlobalId == envelope.AggregateGlobalId) ?? throw new ArgumentException($"{envelope.EventType} must include its aggregate InvoiceTotal record.");
        foreach (var record in envelope.Records)
        {
            if (record.GlobalId == Guid.Empty)
            {
                throw new ArgumentException($"{record.EntityType} has no GlobalId.");
            }

            if (!AllowedEntities.Contains(record.EntityType))
            {
                throw new ArgumentException($"{record.EntityType} is not valid in a {envelope.EventType} event.");
            }
        }
    }
}
