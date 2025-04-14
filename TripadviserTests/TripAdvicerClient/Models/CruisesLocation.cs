namespace TripadviserTests.TripAdvicerClient.Models;


  public class CruisesLocation
  {
    public bool Status { get; set; }
    public string Message { get; set; }
    public long Timestamp { get; set; }
    public List<LocationData> Data { get; set; }
  }

  public class LocationData
  {
    public int DestinationId { get; set; }
    public int LocationId { get; set; }
    public string Name { get; set; }
  }
