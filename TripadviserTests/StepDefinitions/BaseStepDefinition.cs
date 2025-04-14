using Reqnroll;

namespace TripadviserTests;

public class BaseStepDefinition
{
    protected readonly ScenarioContext ScenarioContext;

    public BaseStepDefinition(ScenarioContext scenarioContext)
    {
        ScenarioContext = scenarioContext;
    }
    
}