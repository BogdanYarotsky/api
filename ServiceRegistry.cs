using System.Security.Cryptography;

namespace api;

public class ServiceRegistry(IConfiguration config)
{
    public void Fill(IServiceCollection _)
    {
        _.AddSingleton<RandomFunc>(RandomNumberGenerator.GetInt32);
        _.AddSingleton<NowFunc>(() => DateTime.Now);
        _.AddSingleton(ForecastSummaries.Default);
        _.AddSingleton<RandomForecastsGenerator>();
    }
}