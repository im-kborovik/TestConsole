using System;

namespace Skynet.Dtos.Brokers
{
    public class BrokerDto : CreateBrokerDto
    {
        public Guid BrokerId { get; set; }
    }
}