
---

## ✅ XML Project — `WeatherApiXml/README.md`

```markdown
# Weather API (XML Version)

This ASP.NET Core Web API project fetches current weather data from the OpenWeatherMap API and returns responses in *XML format*.

## 🔧 Features

- Deserializes XML weather responses using `XmlSerializer`
- Uses XML-specific models with `[XmlElement]`, `[XmlRoot]`
- Global exception handling middleware
- Swagger UI with XML support

## 🔐 Configuration

Update `appsettings.json`:

```json
{
  "OpenWeather": {
    "ApiKey": "your_openweather_api_key"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
