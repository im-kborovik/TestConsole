using System;

namespace Skynet.Dtos.Telephony
{
    public class UserTextDTO
    {
            public Guid Id { get; set; }
            public Guid CompanyId { get; set; }
            public string PhoneNumberFrom { get; set; }
            public string PhoneNumberTo { get; set; }
            public bool InBound { get; set; }
            public long? HubSpotContactId { get; set; }
            public string Text { get; set; }
            public DateTime Timestamp { get; set; }
            public bool Read { get; set; }
            public Guid UserId { get; set; }
            public string FullName { get; set; }
            public string DisplayName { get; set; }
            
            public bool Pending { get; set; }
            public bool Failed { get; set; }
    }
}
