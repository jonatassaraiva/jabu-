namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Meta class contain a message which provides additional information intended to help developers debug problems.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Http status code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// A unique string identifier for this request.
        /// </summary>
        public string RequestId { get; set; }
    }
}