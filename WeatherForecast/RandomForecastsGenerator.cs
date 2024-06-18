using static System.Linq.Enumerable;

namespace api;

public class RandomForecastsGenerator(ForecastSummaries summaries, NowFunc nowFunc, RandomFunc rngFunc)
{
    public IEnumerable<WeatherForecast> GetRandomForecasts(int count)
    {
        var now = nowFunc();

        return Range(1, count)
            .Select(i => now.AddDays(i))
            .Select(GetRandomForecast);
    }

    private WeatherForecast GetRandomForecast(DateTime dateTime)
    {
        return new WeatherForecast(
            TemperatureC: rngFunc(-20, 55),
            Summary: summaries[rngFunc(0, summaries.Count)],
            Date: DateOnly.FromDateTime(dateTime)
        );
    }
}