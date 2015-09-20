namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Location class contains information about location and geolocation
    /// </summary>
    public class Location
    {
        public string Address { get; set; }

        public string CrossStreet { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public int Distance { get; set; }

        public string PostalCode { get; set; }

        public string CC { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string[] FormattedAddress { get; set; }
    }
}