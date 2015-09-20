namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    public class Venue
    {
        /// <summary>
        /// A unique string identifier for this Venue.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The best known name for this venue.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An object containing contact information.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// An object containing none, some, or all of address (street address),  crossStreet,  city, state, postalCode, country, lat, lng, and distance.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// An array, possibly empty, of categories that have been applied to this venue.
        /// </summary>
        public Category[] Categories { get; set; }

        /// <summary>
        /// Boolean indicating whether the owner of this business has claimed it and verified the information.
        /// </summary>
        public bool Verified { get; set; }

        /// <summary>
        /// Contains total checkins, total users and number of tips here
        /// </summary>
        public Stats Stats { get; set; }

        /// <summary>
        /// URL of the venue's website, typically provided by the venue manager.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Information about who is here now.
        /// </summary>
        public HereNow HereNow { get; set; }
    }
}