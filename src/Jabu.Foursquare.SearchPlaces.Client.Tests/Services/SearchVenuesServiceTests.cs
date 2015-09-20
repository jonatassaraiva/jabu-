using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Jabu.Foursquare.SearchPlaces.Client.Models;
using Jabu.Foursquare.SearchPlaces.Client.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jabu.Foursquare.SearchPlaces.Client.Tests.Services
{
    [TestClass]
    public class SearchVenuesServiceTests
    {
        [TestMethod]
        public void Search_Sucess()
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var fielPath = Path.Combine(startupPath, "Test_Data", "search.json");

            var mockHandler = new MockHandler(request => new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(File.ReadAllText(fielPath), Encoding.UTF8, "application/json")
            });

            var searchVenuesService = new SearchVenuesService(new HttpClient(mockHandler));

            var result = searchVenuesService.Search().Result;

            Assert.IsNotNull(result);

            var meta = result.Meta;
            Assert.IsNotNull(meta);
            Assert.AreNotEqual(0, meta.Code);
            Assert.AreNotEqual(string.Empty, meta.RequestId);

            var response = result.Response;
            Assert.IsNotNull(result);
            Assert.IsTrue(response.Confident);

            var venues = response.Venues;
            Assert.IsNotNull(venues);
            Assert.IsTrue(venues.Length > 0);

            var firstVenues = venues.First();
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstVenues.Id));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstVenues.Name));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstVenues.URL));
            Assert.IsTrue(firstVenues.Verified);

            var categories = firstVenues.Categories;
            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Length > 0);

            var firstCategory = firstVenues.Categories.First();
            Assert.IsInstanceOfType(firstCategory, typeof(CategoryVenue));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstCategory.Id));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstCategory.Name));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstCategory.PluralName));
            Assert.IsFalse(string.IsNullOrWhiteSpace(firstCategory.ShortName));
            Assert.IsTrue(((CategoryVenue)firstCategory).Primary);

            var icon = firstCategory.Icon;
            Assert.IsNotNull(icon);
            Assert.IsFalse(string.IsNullOrWhiteSpace(icon.Prefix));
            Assert.IsFalse(string.IsNullOrWhiteSpace(icon.Suffix));

            var contact = firstVenues.Contact;
            Assert.IsNotNull(contact);
            Assert.IsFalse(string.IsNullOrWhiteSpace(contact.Facebook));
            Assert.IsFalse(string.IsNullOrWhiteSpace(contact.FacebookName));
            Assert.IsFalse(string.IsNullOrWhiteSpace(contact.FacebookUsername));
            Assert.IsFalse(string.IsNullOrWhiteSpace(contact.FormattedPhone));
            Assert.IsFalse(string.IsNullOrWhiteSpace(contact.Phone));

            var hereNow = firstVenues.HereNow;
            Assert.IsNotNull(hereNow);
            Assert.AreNotEqual(0, hereNow.Count);
            Assert.IsFalse(string.IsNullOrWhiteSpace(hereNow.Summary));

            var location = firstVenues.Location;
            Assert.IsNotNull(location);
            Assert.IsFalse(string.IsNullOrWhiteSpace(location.Address));
            Assert.IsFalse(string.IsNullOrWhiteSpace(location.CC));
            Assert.IsFalse(string.IsNullOrWhiteSpace(location.City));
            Assert.IsFalse(string.IsNullOrWhiteSpace(location.Country));
            Assert.IsFalse(string.IsNullOrWhiteSpace(location.CrossStreet));
            Assert.AreNotEqual(0, location.Distance);
            Assert.IsNotNull(location.FormattedAddress);
            Assert.IsTrue(location.FormattedAddress.Length > 0);
        }
    }
}