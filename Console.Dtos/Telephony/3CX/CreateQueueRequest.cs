using System.Collections.Generic;

namespace Skynet.Dtos.Telephony._3CX
{
    public class CreateQueueRequest
    {
        public string QueueName { get; set; }
        public string QueueNumber { get; set; }
        public ushort RingTimeout { get; set; }
        public List<string> Extensions { get; set; }
    }
}
