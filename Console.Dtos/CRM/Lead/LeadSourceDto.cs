using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.CRM.Lead
{
    public class LeadSourceDto : LeadSourceRequestDto, ITenantDto
    {
        public Guid LeadSourceId { get; set; }
        public Guid CompanyId { get; set; }
    }
}
