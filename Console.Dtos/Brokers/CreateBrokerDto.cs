using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Brokers
{
    public class CreateBrokerDto : BrokerRequest, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}