using System;
using System.Configuration;

namespace Jabu.Foursquare.SearchPlaces.Client.Config
{
    public class ManagerSectionConfig
    {
        private const string SECTION_NAME = "jabuFoursquareSearchPlaces";

        public static SectionConfig JSaraivaFoursquareSearchPlaces
        {
            get
            {
                var jSaraivaFoursquareSearchPlaces = (SectionConfig)ConfigurationManager.GetSection(ManagerSectionConfig.SECTION_NAME);

                if (jSaraivaFoursquareSearchPlaces == null)
                    throw new Exception($"{nameof(jSaraivaFoursquareSearchPlaces)} - not declared in the configuration file");

                return jSaraivaFoursquareSearchPlaces;
            }
        }
    }
}
