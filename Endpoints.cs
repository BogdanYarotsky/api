namespace api;

public static class Endpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder _)
    {
        _.MapGet("/weatherforecast", GetWeatherForecast.Handler);
    }
}