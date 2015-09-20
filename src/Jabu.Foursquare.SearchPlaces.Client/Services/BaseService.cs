using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Jabu.Foursquare.SearchPlaces.Client.Configs;
using Jabu.Foursquare.SearchPlaces.Client.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Jabu.Foursquare.SearchPlaces.Client.Services
{
    public class BaseService
    {
        protected string baseUrl;

        protected readonly HttpClient httpClient;

        protected JsonSerializerSettings settings;

        public BaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.DefaultRequestHeaders.Accept.Clear();
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var jabuFoursquareSearchPlaces = ManagerSectionConfig.JSaraivaFoursquareSearchPlaces;

            this.baseUrl = string.Format(jabuFoursquareSearchPlaces.SearchVenuesService.URL, jabuFoursquareSearchPlaces.ClientId, jabuFoursquareSearchPlaces.ClientSecret, jabuFoursquareSearchPlaces.Version);

            this.settings = new JsonSerializerSettings();
            this.settings.Formatting = Formatting.Indented;
            this.settings.NullValueHandling = NullValueHandling.Ignore;
            this.settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            this.settings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            this.settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            List<JsonConverter> converters = new List<JsonConverter>();
            converters.Add(new CategoryConverter());
            this.settings.Converters = converters;
        }
    }
}