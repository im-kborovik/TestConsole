using System.ComponentModel;

namespace Skynet.Dtos.Enums.Pricing
{
    public enum ScenarioPropertyType : byte
    {
        [Description("SFR")]
        Sfr,
        [Description("CONDO")]
        Condo,
        [Description("DETACHED CONDO")]
        DetachedCondo,
        [Description("PUD")]
        PUD,
        [Description("UNITS-2")]
        Units2,
        [Description("UNITS-3")]
        Units3,
        [Description("UNITS-4")]
        Units4,
        [Description("TOWNHOUSE")]
        Townhouse,
    }
}
