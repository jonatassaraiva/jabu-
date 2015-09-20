namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The CategoryFoursquare class containing sub- and sub-sub- categories.
    /// </summary>
    public class CategoryFoursquare : Category
    {
        /// <summary>
        /// Array of categories that are descendants of this category in the hierarchy.
        /// </summary>
        public Category[] categories { get; set; }
    }
}