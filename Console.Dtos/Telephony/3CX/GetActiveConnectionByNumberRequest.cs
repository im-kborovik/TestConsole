

using Skynet.Dtos.Telephony._3CX.Events;

namespace Skynet.Dtos.Telephony._3CX
{
    public class GetActiveConnectionByNumberRequest
    {
        public string ExtNumber { get; set; }
        public ConnectionStatus FilterByStatus { get; set; }
        public int CloneDepth { get; set; }
    }
}
