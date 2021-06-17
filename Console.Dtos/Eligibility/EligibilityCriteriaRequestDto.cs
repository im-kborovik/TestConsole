using System;

namespace Skynet.Dtos.Eligibility
{
    public class EligibilityCriteriaRequestDto
    {
        public string Name { get; set; }

        public bool Deny { get; set; }
        
        public Guid? ParentCriteriaId { get; set; }

        public Guid? BaseCriteriaId { get; set; }

        public bool Enabled { get; set; }

        public string Expression { get; set; }

        public string UserFriendlyExpression { get; set; }
        
        public string DenialReason { get; set; }
    }
}
