using System.Collections.ObjectModel;

namespace api;

public class ForecastSummaries(IList<string> list) : ReadOnlyCollection<string>(list)
{
    private static readonly string[] DefaultSummaries =
    [
        "Freezing", "Bracing", "Chilly",
        "Cool", "Mild", "Warm", "Balmy",
        "Hot", "Sweltering", "Scorching"
    ];

    public static ForecastSummaries Default => new(DefaultSummaries);
}