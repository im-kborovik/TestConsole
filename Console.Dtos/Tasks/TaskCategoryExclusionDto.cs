using Skynet.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Tasks
{
    public class TaskCategoryExclusionDto : ITenantDto
    {
        public Guid CompanyId { get; set; }
        public Guid TaskCategoryId { get; set; }
    }
}
