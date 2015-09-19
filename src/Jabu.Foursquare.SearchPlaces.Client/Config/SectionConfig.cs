using System.Configuration;

namespace Jabu.Foursquare.SearchPlaces.Client.Config
{
    public class SectionConfig : ConfigurationSection
    {
        // <summary>
        /// Application name
        /// </summary>
        [ConfigurationProperty("application", IsRequired = false)]
        public string Application
        {
            get { return (string)base["application"]; }

            set { base["application"] = value; }
        }

        /// <summary>
        /// API client ID
        /// </summary>
        [ConfigurationProperty("clientId", IsRequired = false)]
        public string ClientId
        {
            get { return (string)base["clientId"]; }

            set { base["clientId"] = value; }
        }

        /// <summary>
        /// API client secret
        /// </summary>
        [ConfigurationProperty("clientSecret", IsRequired = false)]
        public string ClientSecret
        {
            get { return (string)base["clientSecret"]; }

            set { base["clientSecret"] = value; }
        }

        /// <summary>
        /// A clientVersion parameter, which is a date that essentially represents the "version" of the API that client expect from Foursquare.
        /// </summary>
        [ConfigurationProperty("clientVersion", IsRequired = false)]
        public string Version
        {
            get { return (string)base["clientVersion"]; }

            set { base["clientVersion"] = value; }
        }
    }
}
