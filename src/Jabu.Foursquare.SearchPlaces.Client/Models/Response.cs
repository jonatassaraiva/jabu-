namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Response class contains feedback information for the request
    /// </summary>
    public class Response
    {
        /// <summary>
        /// An array of compact Venue.
        /// </summary>
        public Venue[] Venues { get; set; }

        public bool Confident { get; set; }
    }
}