using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BotigaSync.API.Controllers;

// Separate, additive endpoint for the staging-table backfill approach - does not touch
// SyncController or ISyncEventService. Just a fast raw dump into stg.[tableName], no
// resolve/apply logic. See BulkStagingService for the actual bulk-copy work.
[ApiController]
[Route("api/bulk-staging")]
public class BulkStagingController : ControllerBase
{
    [HttpPost("{tableName}/rows")]
    public async Task<ActionResult<BulkStagingResponse>> InsertRows(
        [FromServices] IBulkStagingService stagingService,
        string tableName,
        BulkStagingRequest request,
        CancellationToken cancellationToken)
    {
        if (request.StoreId <= 0 || request.Rows.Count == 0 || request.BatchId == Guid.Empty)
        {
            return BadRequest(new BulkStagingResponse { Success = false, ErrorMessage = "storeId, batchId, and at least one row are required." });
        }

        var response = await stagingService.InsertRowsAsync(tableName, request, cancellationToken);
        return response.Success ? Ok(response) : UnprocessableEntity(response);
    }
}
