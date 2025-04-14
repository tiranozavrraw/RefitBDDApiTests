using Microsoft.Extensions.Logging;

namespace TripadviserTests.HttpHandlers;

public class LoggingDelegatingHandler : DelegatingHandler
{
    private readonly ILogger<LoggingDelegatingHandler> _logger;

    public LoggingDelegatingHandler(ILogger<LoggingDelegatingHandler> logger)
    {
        _logger = logger;
    }
    
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);
        _logger.LogInformation("Request: {Request}, Response: {Response}, StatusCode: {StatusCode}", request, response, response.StatusCode);
        return response;
    }
}