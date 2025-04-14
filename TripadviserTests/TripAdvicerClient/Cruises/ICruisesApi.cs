using Refit;
using TripadviserTests.TripAdvicerClient.Models;

namespace TripadviserTests.TripAdvicerClient.Cruises;

public interface ICruisesApi
{
    [Get("/cruises/searchCruises")]
    public Task<SearchCruisesResponse?> SearchCruisesAsync(SearchCruisesQueryParameters parameters);

    [Get("/cruises/getLocation")]
    public Task<CruisesLocation> GetCruisesLocationAsync();
}
