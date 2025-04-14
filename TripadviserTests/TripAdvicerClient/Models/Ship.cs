namespace TripadviserTests.TripAdvicerClient.Models;

public class Ship
{
    public int Id { get; set; }
    public long LocationId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public Snippets Snippets { get; set; }
    public ReviewSummaryInfo ReviewSummaryInfo { get; set; }
    public int PassengerCapacity { get; set; }
    public Amenities Amenities { get; set; }
    public int LaunchYear { get; set; }
    public int Crew { get; set; }
}