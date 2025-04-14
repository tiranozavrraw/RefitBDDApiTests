using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Refit;
using Reqnroll.Microsoft.Extensions.DependencyInjection;
using TripadviserTests.TripAdvicerClient.Cruises;
using Serilog;
using TripadviserTests.HttpHandlers;

namespace TripadviserTests;

public static class StartUp
{
    [ScenarioDependencies]
    private static IServiceCollection ServiceCollection()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .AddJsonFile("appSettings." + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") + ".json", true)
            .AddJsonFile("appSettings.local.json", true)
            .AddEnvironmentVariables()
            .Build();
        serviceCollection.AddSingleton(configuration);
        serviceCollection.AddTransient<AuthorizationHandler>(x => new AuthorizationHandler("test"));
        serviceCollection.AddTransient<LoggingDelegatingHandler>();

        serviceCollection.AddRefitClient<ICruisesApi>()
            .ConfigureHttpClient(
                (serviceProvider, httpClient) =>
                {
                    var config = serviceProvider.GetRequiredService<IConfiguration>();
                    var baseUrl = config["TripAdvisorRapidAPI:BaseUrl"]
                                  ?? throw new ArgumentNullException(nameof(IConfiguration));
                    httpClient.BaseAddress = new Uri(baseUrl);
                    httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", config["TripAdvisorRapidAPI:ApiHostHeader"]);
                })
            .AddHttpMessageHandler<AuthorizationHandler>()
            .AddHttpMessageHandler<LoggingDelegatingHandler>();
        
        serviceCollection.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog(new LoggerConfiguration()
                .WriteTo.Console()
                //.WriteTo.File("log.txt")
                .CreateLogger());
        });
        
        return serviceCollection;
    }
}