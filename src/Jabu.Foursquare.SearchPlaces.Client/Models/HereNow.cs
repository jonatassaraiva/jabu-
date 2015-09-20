namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The HereNow class contains information about who is here now. If present, there is always a count, the number of people here.
    /// </summary>
    public class HereNow
    {
        public int Count { get; set; }

        public string Summary { get; set; }

        // TODO: If viewing details and there is a logged-in user, there is also a groups field with friends and others as types.
    }
}