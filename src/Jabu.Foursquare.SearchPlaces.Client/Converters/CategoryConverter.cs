using System;
using Jabu.Foursquare.SearchPlaces.Client.Models;
using Newtonsoft.Json.Linq;

namespace Jabu.Foursquare.SearchPlaces.Client.Converters
{
    public class CategoryConverter : AbstractJsonConverter<Category>
    {
        protected override Category Create(Type objectType, JObject jObject)
        {
            if (FieldExists(jObject, "primary", JTokenType.Boolean))
                return new CategoryVenue();

            if (FieldExists(jObject, "categories", JTokenType.Array))
                return new CategoryVenue();

            throw new InvalidOperationException();
        }
    }
}