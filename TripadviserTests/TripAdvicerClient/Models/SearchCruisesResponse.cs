namespace TripadviserTests.TripAdvicerClient.Models;

  public class SearchCruisesResponse
{
    public bool Status { get; set; }
    public string Message { get; set; }
    public long Timestamp { get; set; }
    public CruiseData Data { get; set; }
}

  public class Snippets
{
    public PickIf PickIf { get; set; }
    public SkipIf SkipIf { get; set; }
}

public class PickIf
{
    public List<string> Results { get; set; }
}

public class SkipIf
{
    public List<string> Results { get; set; }
}

public class ReviewSummaryInfo
{
    public int OverallRatings { get; set; }
    public int NumberReviews { get; set; }
    public List<ReviewSnippet> ReviewSnippets { get; set; }
}

public class ReviewSnippet
{
    public int Rating { get; set; }
    public string UserId { get; set; }
    public string ReviewText { get; set; }
}

public class Amenities
{
    public List<string> Results { get; set; }
}

public class Destination
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SeoName { get; set; }
    public string ImageUrl { get; set; }
}

public class DeparturePorts
{
    public List<Port> Results { get; set; }
}

public class Port
{
    public int? Id { get; set; }
    public string Name { get; set; }
}

public class Itinerary
{
    public List<ItineraryResult> Results { get; set; }
}

public class ItineraryResult
{
    public int Day { get; set; }
    public Port Port { get; set; }
}

public class Sailings
{
    public int TotalResults { get; set; }
    public List<SailingResult> Results { get; set; }
}

public class SailingResult
{
    public int PriceId { get; set; }
    public string DepartureDate { get; set; }
    public int Id { get; set; }
}

public class CruiseFilters
{
    public List<CruiseLineFilter> CruiseLines { get; set; }
    public List<DealsType> DealsType { get; set; }
    public List<DepartingFrom> DepartingFrom { get; set; }
    public List<CruiseLength> CruiseLength { get; set; }
    public List<CruiseStyle> CruiseStyle { get; set; }
    public List<ShipFilter> Ship { get; set; }
    public List<PortFilter> Port { get; set; }
}

public class CruiseLineFilter
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class DealsType
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class DepartingFrom
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class CruiseLength
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class CruiseStyle
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class ShipFilter
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}

public class PortFilter
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int TotalResults { get; set; }
}