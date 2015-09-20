using System.Configuration;

namespace Jabu.Foursquare.SearchPlaces.Client.Configs
{
    public class ServiceConfig : ConfigurationElement
    {
        /// <summary>
        /// HTTP URL of service
        /// </summary>
        [ConfigurationProperty("url", IsRequired = true)]
        public string URL
        {
            get
            {
                return (string)base["url"];
            }
            set
            {
                base["url"] = value;
            }
        }
    }
}