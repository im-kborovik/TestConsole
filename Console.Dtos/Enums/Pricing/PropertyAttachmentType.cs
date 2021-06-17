using System.ComponentModel;

namespace Skynet.Dtos.Enums.Pricing
{
    public enum PropertyAttachmentType: byte
    {
        [Description("Attached")]
        Attached = 0,
        [Description("Detached")]
        Detached = 1,
        [Description("Semi-Detached")]
        SemiDetached = 2
    }
}
