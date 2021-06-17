using System;

namespace Skynet.Dtos.Attributes.HubSpot
{
    public class HubSpotPropertyAttribute : Attribute
    {
        public string Name { get; set; }
        
        public bool SendEmpty { get; set; }

        public HubSpotPropertyAttribute( )
        {
        }
    }
}
