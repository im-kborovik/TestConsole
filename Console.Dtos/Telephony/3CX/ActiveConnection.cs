using System;
using System.Collections.Generic;
using Skynet.Dtos.Telephony._3CX.Events;

namespace Skynet.Dtos.Telephony._3CX
{
    public class ActiveConnection
    {
        public DateTime LastChangeStatus { get; set; }

        public DN DN { get; set; }

        public DN OnBehalfOf { get; set; }

        public int CallID { get; set; }

        public int CallConnectionID { get; set; }

        public int ReferredBy { get; set; }

        public DN OriginatedBy { get; set; }

      
        public ConnectionStatus Status { get; set; }

        public DN InternalParty { get; set; }

        public string ExternalParty { get; set; }

        public string DialedNumber { get; set; }

        public bool IsInbound { get; set; }

        public bool IsOutbound { get; set; }

        public Dictionary<string, string> AttachedData { get; set; }

        public RecordingAction RecordingState { get; set; }

        public ActiveConnection[] OtherCallParties { get; set; }

        public int ID { get; set; }
    }
}
