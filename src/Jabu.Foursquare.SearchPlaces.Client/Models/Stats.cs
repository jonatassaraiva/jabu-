namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Stas class contains total checkins ever here, total users who have ever checked in here, and number of tips here.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Total checkins ever here.
        /// </summary>
        public int CheckinsCount { get; set; }

        /// <summary>
        /// Total users who have ever checked in here.
        /// </summary>
        public int UsersCount { get; set; }

        /// <summary>
        /// Number of tips here.
        /// </summary>
        public int TipCount { get; set; }
    }
}