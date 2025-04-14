namespace TripadviserTests.TripAdvicerClient.Models;

public class Cruise
{
    public long ShipId { get; set; }
    public string SeoName { get; set; }
    public string Title { get; set; }
    public int Length { get; set; }
    public int Id { get; set; }
    public CruiseLine CruiseLine { get; set; }
    public Ship Ship { get; set; }
    public Destination Destination { get; set; }
    public DeparturePorts DeparturePorts { get; set; }
    public Port PortDeparture { get; set; }
    public Port PortArrival { get; set; }
    public Itinerary Itinerary { get; set; }
    public Sailings Sailings { get; set; }
}