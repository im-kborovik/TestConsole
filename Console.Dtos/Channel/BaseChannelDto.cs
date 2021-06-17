using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Channel
{
    public class BaseChannelDto : ChannelRequest, ITenantDto
    {
        public Guid CompanyId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}