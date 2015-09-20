using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Jabu.Foursquare.SearchPlaces.Client.Tests
{
    public class MockHandler : HttpMessageHandler
    {
        private Func<HttpRequestMessage, HttpResponseMessage> _httpResponseGenerator;

        public MockHandler(Func<HttpRequestMessage, HttpResponseMessage> _httpResponseGenerator)
        {
            this._httpResponseGenerator = _httpResponseGenerator;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var response = _httpResponseGenerator(request);
            response.RequestMessage = request;

            return Task.FromResult(response);
        }
    }
}