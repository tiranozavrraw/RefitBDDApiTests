using Microsoft.Extensions.Logging;

namespace TripadviserTests.HttpHandlers;

public class AuthorizationHandler : DelegatingHandler
{
    private readonly string _apiKey;
    
    public AuthorizationHandler(string apiKey)
    {
        _apiKey = apiKey;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
        var response = await base.SendAsync(request, cancellationToken);
        return response;
    }
}
