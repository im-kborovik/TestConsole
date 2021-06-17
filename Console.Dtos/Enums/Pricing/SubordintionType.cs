using System.ComponentModel;

namespace Skynet.Dtos.Enums.Pricing
{
    public enum SubordinationType :byte
    {
        [Description("HELOC")]
        Heloc = 0,
        [Description("Non-HELOC")]
        NonHeloc = 1
    }
}
