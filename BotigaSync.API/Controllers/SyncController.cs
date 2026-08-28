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
}
