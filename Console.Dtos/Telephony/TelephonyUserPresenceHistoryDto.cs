using System;

namespace Skynet.Dtos.Telephony
{
    public class TelephonyUserPresenceHistoryDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; }
        public string PreviousStatus { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
