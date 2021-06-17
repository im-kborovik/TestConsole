using System;

namespace Skynet.Dtos.Telephony
{
    public class CallDetailDTO
    {
        public Guid CompanyId { get; set; }
        public long? Duration { get; set; }
        public string FromPhoneNumber { get; set; }
        public string ToPhoneNumber { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string PhoneSystemId { get; set; }
        public string RecordingURL { get; set; }
        public string CRMId { get; set; }
        public int? CallDisposition { get; set; }
    }
}