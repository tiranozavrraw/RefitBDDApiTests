namespace TripadviserTests.TripAdvicerClient.Models;

public class CruiseLine
{
    public int Id { get; set; }
    public long LocationId { get; set; }
    public string Name { get; set; }
    public string IconUrl { get; set; }
    public string LogoUrl { get; set; }
}