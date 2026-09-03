using System.Security.Cryptography;
using System.Text;

namespace BotigaSync.API.Middleware;

public class ApiKeyMiddleware(RequestDelegate next, IConfiguration config)
{
    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Path.StartsWithSegments("/api/sync"))
        {
            await next(context);
            return;
        }

        var expected = config["SyncSecurity:ApiKey"];
        var supplied = context.Request.Headers["X-Botiga-Sync-Key"].ToString();
        var authorized = !string.IsNullOrWhiteSpace(expected)
            && !string.IsNullOrWhiteSpace(supplied)
            && CryptographicOperations.FixedTimeEquals(Encoding.UTF8.GetBytes(expected), Encoding.UTF8.GetBytes(supplied));

        if (!authorized)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsJsonAsync(new { success = false, message = "Unauthorized sync request." });
            return;
        }

        await next(context);
    }
}
