using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BotigaSync.API.Controllers;

[ApiController]
[Route("api/sync")]
public class SyncController : ControllerBase
{
    [HttpPost("events")]
    public async Task<ActionResult<SyncEventResponse>> PostEvent(
        [FromServices] ISyncEventService eventService,
        SyncEventEnvelope envelope,
        CancellationToken cancellationToken)
    {
        var response = await eventService.ProcessAsync(envelope, cancellationToken);
        if (!response.Success)
        {
            return UnprocessableEntity(response);
        }

        return Ok(response);
    }

    [HttpGet("events/next")]
    public async Task<ActionResult<OutboxEventResponse>> PullNextEvent(
        [FromServices] IOutboxEventService outboxEventService,
        [FromQuery] int storeId,
        CancellationToken cancellationToken)
    {
        if (storeId <= 0)
        {
            return BadRequest(new { success = false, message = "storeId is required." });
        }

        var next = await outboxEventService.PullNextAsync(storeId, cancellationToken);
        return next == null ? NoContent() : Ok(next);
    }

    [HttpPost("events/ack")]
    public async Task<ActionResult<AckEventResponse>> AcknowledgeEvent(
        [FromServices] IOutboxEventService outboxEventService,
        AckEventRequest request,
        CancellationToken cancellationToken)
    {
        if (request.StoreId <= 0 || request.EventId == Guid.Empty)
        {
            return BadRequest(new { success = false, message = "storeId and eventId are required." });
        }

        var response = await outboxEventService.AcknowledgeAsync(request, cancellationToken);
        return response.Success ? Ok(response) : UnprocessableEntity(response);
    }
}
