using System;

namespace Skynet.Dtos.Telephony
{
    public class TelephonyUserPresenceDto
    {
        public Guid UserId { get; set; }
        public string Status { get; set; }
        public DateTime LastChanged { get; set; }
    }
}
