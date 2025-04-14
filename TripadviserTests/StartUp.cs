using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Refit;
using TripadviserTests.TripAdvicerClient.Cruises;

namespace TripadviserTests;

public abstract class StartUp
{
    public static ServiceProvider BuildServiceProvider()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .AddJsonFile("appSettings." + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") + ".json", true)
            .AddJsonFile("appSettings.local.json", true)
            .AddEnvironmentVariables()
            .Build();
        serviceCollection.AddSingleton(configuration);

        serviceCollection.AddRefitClient<ICruisesApi>()
            .ConfigureHttpClient(
                (serviceProvider, httpClient) =>
                {
                    var config = serviceProvider.GetRequiredService<IConfiguration>();
                    var baseUrl = config["TripAdvisorRapidAPI:BaseUrl"]
                                  ?? throw new ArgumentNullException(nameof(IConfiguration));
                    httpClient.BaseAddress = new Uri(baseUrl);
                });

        //serviceCollection.AddHttpClient("TripAdvisorClient", client =>
        //{
        //    client.BaseAddress = new Uri(configuration["TripAdvisorRapidAPI:BaseUrl"]);
        //});


        return serviceCollection.BuildServiceProvider();
    }
}