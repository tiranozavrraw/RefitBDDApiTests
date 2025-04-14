namespace TripadviserTests.TripAdvicerClient.Models;

public class CruiseData
{
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
    public List<Cruise> List { get; set; }
    public object Price { get; set; }
    public CruiseFilters Filters { get; set; }
}