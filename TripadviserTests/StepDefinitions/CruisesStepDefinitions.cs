using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Reqnroll;
using Shouldly;
using TripadviserTests.TripAdvicerClient.Cruises;
using TripadviserTests.TripAdvicerClient.Models;

namespace TripadviserTests;

[Binding]
public class CruisesStepDefinitions : BaseStepDefinition
{
    private readonly ICruisesApi _cruisesApi;
    private readonly ScenarioContext _scenarioContext;
    private readonly ILogger<CruisesStepDefinitions> _logger;

    public CruisesStepDefinitions(ICruisesApi cruisesApi, ScenarioContext scenarioContext, ILogger<CruisesStepDefinitions> logger) : base(scenarioContext)
    {
        _cruisesApi = cruisesApi;
        _scenarioContext = scenarioContext;
        _logger = logger;
    }
    
    
    [Given(@"Cruise with Destination (.*)")]
    public async Task GivenCruiseWithDestinationAndDestinationId(string destination)
    {
        var cruisesLocations = await _cruisesApi.GetCruisesLocationAsync();
        cruisesLocations.Data.ShouldNotBeEmpty();
        cruisesLocations.Data.ShouldContain(x => x.Name == destination);
        var destinationId = cruisesLocations.Data.FirstOrDefault(x => x.Name == destination)!.DestinationId;
        _scenarioContext.Add("DestinationId", destinationId);
    }
 
    
    [When(@"Search for cruises with DestinationId and Order (.*)")]
    public async Task WhenSearchForCruisesWithDestinationIdAndOrder(Order order)
    {
        var destinationId = _scenarioContext["DestinationId"];
        var cruises = await _cruisesApi.SearchCruisesAsync(new SearchCruisesQueryParameters
        {
            DestinationId = destinationId.ToString()!,
            Order = order
        });
        _scenarioContext.Add("Cruises", cruises);
    }
    
    [Then(@"the result should contain cruises with printed titles and sorted by number of crew")]
    public void ThenTheResultShouldContainCruises()
    {
        var cruises = (SearchCruisesResponse) _scenarioContext["Cruises"];
        cruises.Data.List.ShouldNotBeEmpty();

        var shipTitles = cruises!.Data.List.Select(x => x.Title).ToList();
        _logger.LogInformation("Cruise titles");
        foreach (var title in shipTitles)
        {
            _logger.LogInformation(title); 
            
        }
        var cruisesInfoSorted = cruises!.Data.List.OrderByDescending(x => x.Ship.Crew).ToList();
        _logger.LogInformation("Cruises sorted by number of crew");
        foreach (var cruise in cruisesInfoSorted)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(cruise));
        }
    }
}