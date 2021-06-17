using Skynet.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Tasks
{
    public class TaskTypeExclusionDto : ITenantDto
    {
        public Guid CompanyId { get; set; }
        public Guid TaskTypeId { get; set; }
    }
}
