namespace api;

public static class WebApi
{
    public static WebApplication Create(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        new ServiceRegistry(builder.Configuration)
            .Fill(builder.Services);

        var app = builder.Build();
        app.MapEndpoints();
        return app;
    }
}