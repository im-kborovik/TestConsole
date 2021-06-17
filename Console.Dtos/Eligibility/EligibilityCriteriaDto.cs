using System;
using Skynet.Dtos.Common;
using Skynet.Dtos.CriteriaTree;

namespace Skynet.Dtos.Eligibility
{
    public class EligibilityCriteriaDto : CriteriaTreeNodeBaseDto, ITenantDto
    {
        public Guid CompanyId { get; set; }

        public bool Deny { get; set; }

        public string DenialReason { get; set; }
        
        public bool IsOverride => BaseCriteriaId != null;
    }
}
