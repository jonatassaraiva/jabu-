namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Contact class contains information from social networks and phones.
    /// </summary>
    public class Contact
    {
        public string Phone { get; set; }

        public string FormattedPhone { get; set; }

        public string Twitter { get; set; }

        public string Facebook { get; set; }

        public string FacebookUsername { get; set; }

        public string FacebookName { get; set; }
    }
}