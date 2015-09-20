using Jabu.Foursquare.SearchPlaces.Client.Configs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jabu.Foursquare.SearchPlaces.Client.Tests.Configs
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void Tests_Section()
        {
            var jabuFoursquareSearchPlaces = ManagerSectionConfig.JSaraivaFoursquareSearchPlaces;

            Assert.IsNotNull(jabuFoursquareSearchPlaces);
            Assert.AreEqual("Search Places Client", jabuFoursquareSearchPlaces.Application);
            Assert.AreEqual("QEFLOOGZEJTMXPDYP3SK1XCP00HCVCAOYXVABHFE1YW1M5XL", jabuFoursquareSearchPlaces.ClientId);
            Assert.AreEqual("BSEVYTYOIP5UMAOZLCKR4W2XNJUWORYBDALW2HZIJUWCAUR0", jabuFoursquareSearchPlaces.ClientSecret);
            Assert.AreEqual("20150901", jabuFoursquareSearchPlaces.Version);

            var searchVenuesServiceConfig = jabuFoursquareSearchPlaces.SearchVenuesService;
            Assert.IsNotNull(searchVenuesServiceConfig);
            Assert.AreEqual("https://api.foursquare.com/v2/venues/search?client_id={0}&client_secret={1}&v={2}", searchVenuesServiceConfig.URL);
        }
    }
}