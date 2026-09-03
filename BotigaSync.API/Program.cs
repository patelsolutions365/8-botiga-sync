using System.Text.Json.Serialization;
using BotigaSync.API.Middleware;
using BotigaSync.API.Utilities;
using BotigaSync.Repository.MasterData;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, services, logger) => logger.ReadFrom.Configuration(context.Configuration).ReadFrom.Services(services));
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<MasterBotigaDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MasterDatabase"), sql => sql.EnableRetryOnFailure()));
builder.Services.ConfigureAppServices();

var app = builder.Build();
app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
