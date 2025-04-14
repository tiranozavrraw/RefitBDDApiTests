using Refit;
using TripadviserTests.TripAdvicerClient.Models;

namespace TripadviserTests.TripAdvicerClient.Cruises;

public interface ICruisesApi
{
    [Get("/users/{userId}")]
    public Task<List<SearchCruisesResponse>?> SearchCruisesAsync(
        [Query(".", "")] SearchCruisesQueryParameters parameters);
}
