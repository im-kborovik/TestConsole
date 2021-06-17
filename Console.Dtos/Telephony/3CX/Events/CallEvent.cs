using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Telephony._3CX.Events
{
    public class CallEvent
    {
        public Guid AppUniqueCallStart { get; set; }
        public long DurationSeconds { get; set; }
        public Guid CompanyId { get; set; }
        public EventAction EventAction { get; set; }
        public string MainAddressNumberOrData0 { get; set; }
        public string MainNumber { get; set; }
        public string MainActualTypeName { get; set; }
        
        public string BehalfAddressNumberOrData0 { get; set; }
        public string BehalfNumber { get; set; }
        public string BehalfActualTypeName { get; set; }
        
        public string OriginatedAddressNumberOrData0 { get; set; }
        public string OriginatedNumber { get; set; }
        public string OriginatedActualTypeName { get; set; }
        
        public string InternalPartyAddressNumberOrData0 { get; set; }
        public string InternalPartyNumber { get; set; }
        public string InternalPartyActualTypeName { get; set; }
        
        
        public int? CallID { get; set; }
        public int? CallConnectionID { get; set; }
        
        public string ExternalParty { get; set; }

        public string DialedNumber { get; set; }
        public bool? IsInbound { get; set; }

        public bool? IsOutbound { get; set; }
        public  ConnectionStatus ConnectionStatus { get; set; }
       public RecordingAction RecordingState { get; set; }
       public Dictionary<string,string> AttachedData { get; set; }
       
       public DateTime Timestamp { get; set; }
    }

    public enum EventAction
    {
        Inserted,
        Updated,
        Deleted
    }
    public enum ConnectionStatus
    {
        _Any = -1, // 0xFFFFFFFF
        Undefined = 0,
        Dialing = 1,
        Ringing = 2,
        Connected = 3,
        Hold = 4,
        Held = 5
    }
    public enum RecordingAction
    {
        Start,
        Stop,
        Pause,
        Resume
    }
}
