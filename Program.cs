using WeatherAPIXml.Middleware;
using WeatherAPIXml.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<OpenWeatherSettings>(
    builder.Configuration.GetSection("OpenWeatherVault"));

builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true; // Allow Accept: application/xml
})
.AddXmlSerializerFormatters();

builder.Services.AddHttpClient();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
