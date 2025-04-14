namespace TripadviserTests.TripAdvicerClient.Cruises;

public class SearchCruisesQueryParameters
{
    public string DestinationId { get; set; }
    public string DepartureDate { get; set; }
    public Order Order { get; set; }
    public int Page { get; set; } = 1;
    public string CurrencyCode { get; set; } = "USD";
   
}