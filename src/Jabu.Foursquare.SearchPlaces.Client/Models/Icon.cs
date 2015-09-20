namespace Jabu.Foursquare.SearchPlaces.Client.Models
{
    /// <summary>
    /// The Category class  icons at various sizes.
    /// Combine prefix with a size (32, 44, 64, and 88 are available) and suffix, e.g. https://foursquare.com/img/categories/food/default_64.png.
    ///  To get an image with a gray background, use bg_ before the size, e.g. https://foursquare.com/img/categories_v2/food/icecream_bg_32.png.
    /// </summary>
    public class Icon
    {
        public string Prefix { get; set; }

        public string Suffix { get; set; }
    }
}