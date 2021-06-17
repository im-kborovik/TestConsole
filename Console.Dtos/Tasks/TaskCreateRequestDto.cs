using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Tasks
{
    public class TaskCreateRequestDto : TaskRequestDto, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}