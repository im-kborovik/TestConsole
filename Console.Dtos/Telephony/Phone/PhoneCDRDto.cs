using System;

namespace Skynet.Dtos.Telephony.Phone
{
    public class PhoneCDRDto
    {
        public string ID { get; set; }
        public string Provider { get; set; }

        public string EventType { get; set; }
        public DateTime Timestamp { get; set; }
        public string FromPhoneNumber { get; set; }
        public string ToPhoneNumber { get; set; }
        public string Direction { get; set; }
    }
}
