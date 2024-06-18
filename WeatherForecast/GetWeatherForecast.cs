
namespace api;

public static class GetWeatherForecast
{
    public static IResult Handler(RandomForecastsGenerator generator, int? count)
    {
        var forecasts = generator.GetRandomForecasts(count ?? 5);
        return Results.Ok(forecasts);
    }
}