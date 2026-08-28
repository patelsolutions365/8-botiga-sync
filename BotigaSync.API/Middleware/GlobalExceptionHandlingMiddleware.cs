using Serilog;

namespace BotigaSync.API.Middleware;

public class GlobalExceptionHandlingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (ArgumentException exception)
        {
            Log.Warning(exception, "Invalid sync request");
            context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            await context.Response.WriteAsJsonAsync(new { success = false, message = exception.Message });
        }
        catch (InvalidOperationException exception)
        {
            Log.Warning(exception, "Sync request could not be processed");
            context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            await context.Response.WriteAsJsonAsync(new { success = false, message = exception.Message });
        }
        catch (Exception exception)
        {
            Log.Error(exception, "Unhandled sync service error");
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsJsonAsync(new { success = false, message = "Internal server error." });
        }
    }
}
