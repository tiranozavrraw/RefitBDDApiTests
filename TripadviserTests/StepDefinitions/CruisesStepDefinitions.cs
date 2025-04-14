using Reqnroll;
using TripadviserTests.TripAdvicerClient.Cruises;

namespace TripadviserTests;

[Binding]
public class CruisesStepDefinitions : BaseStepDefinition
{
    private readonly ICruisesApi _cruisesApi;

    public CruisesStepDefinitions(ICruisesApi cruisesApi)
    {
        _cruisesApi = cruisesApi;
    }
    
    
    [Given(@"Cruise with Destination Caribbean and DestinationId (.*)")]
    public void GivenCruiseWithDestinationCaribbeanAndDestinationId(int p0)
    {
        ScenarioContext.StepIsPending();
    }
 
    
    [When(@"Search for cruises with DestinationId (.*) and Order (.*)")]
    public void WhenSearchForCruisesWithDestinationIdAndOrder(string destinationId, string order)
    {
        var cruises = _cruisesApi.SearchCruisesAsync(new SearchCruisesQueryParameters
        {
            DestinationId = destinationId,
            Order = Enum.Parse<Order>(order)
        });
    }
    
    [Then(@"the result should contain cruises")]
    public void ThenTheResultShouldContainCruises()
    {
        //TODO: Redo this step
        // Implement logic to verify that the result contains cruises
        ScenarioContext.StepIsPending();
    }
}