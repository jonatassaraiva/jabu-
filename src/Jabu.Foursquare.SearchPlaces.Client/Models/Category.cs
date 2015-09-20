namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Category class containing information about an Category.
    /// </summary>
    public abstract class Category
    {
        /// <summary>
        /// A unique identifier for this category.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Pluralized version of the category name.
        /// </summary>
        public string PluralName { get; set; }

        /// <summary>
        /// Shorter version of the category name.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Category icon.
        /// </summary>
        public Icon Icon { get; set; }
    }
}