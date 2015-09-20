using System.Net.Http;
using System.Threading.Tasks;
using Jabu.Foursquare.SearchPlaces.Client.Models;
using Newtonsoft.Json;

namespace Jabu.Foursquare.SearchPlaces.Client.Services
{
    public class SearchVenuesService : BaseService
    {
        public SearchVenuesService(HttpClient httpClient) : base(httpClient)
        { }

        /// <summary>
        /// Returns a list of venues near the current location, optionally matching a search term.
        /// </summary>
        /// <returns></returns>
        public async Task<RootObject> Search()
        {
            var urlSearch = string.Format($"{this.baseUrl}&ll=40.7,-74");

            HttpResponseMessage response = await this.httpClient.GetAsync(urlSearch);

            var content = await response.Content.ReadAsStringAsync();

            var rootObject = JsonConvert.DeserializeObject<RootObject>(content, this.settings);

            return rootObject;
        }
    }
}