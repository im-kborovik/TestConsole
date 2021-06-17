using System;

namespace Skynet.Dtos.Telephony._3CX.Events
{
    public class PresenceChangeEvent
    {
        public Guid CompanyId { get; set; }
        public string Extension { get; set; }
        public string CurrentPresence { get; set; }
        public string PastPresence { get; set; }
    }
}
