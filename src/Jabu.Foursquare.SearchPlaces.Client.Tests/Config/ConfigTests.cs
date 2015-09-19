using Jabu.Foursquare.SearchPlaces.Client.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jabu.Foursquare.SearchPlaces.Client.Tests.Config
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void Tests_Section()
        {
            var jSaraivaFoursquareSearchPlaces = ManagerSectionConfig.JSaraivaFoursquareSearchPlaces;

            Assert.IsNotNull(jSaraivaFoursquareSearchPlaces);
            Assert.AreEqual("Search Places Client", jSaraivaFoursquareSearchPlaces.Application);
            Assert.AreEqual("QEFLOOGZEJTMXPDYP3SK1XCP00HCVCAOYXVABHFE1YW1M5XL", jSaraivaFoursquareSearchPlaces.ClientId);
            Assert.AreEqual("BSEVYTYOIP5UMAOZLCKR4W2XNJUWORYBDALW2HZIJUWCAUR0", jSaraivaFoursquareSearchPlaces.ClientSecret);
            Assert.AreEqual("20150901", jSaraivaFoursquareSearchPlaces.Version);
        }
    }
}
