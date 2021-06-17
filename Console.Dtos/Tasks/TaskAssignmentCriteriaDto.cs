using System;
using Skynet.Dtos.Common;
using Skynet.Dtos.CriteriaTree;

namespace Skynet.Dtos.Tasks
{
    public class TaskAssignmentCriteriaDto : CriteriaTreeNodeBaseDto, ITenantDto
    {
        public Guid CompanyId { get; set; }
        
        public Guid? TaskTypeId { get; set; }
    }
}