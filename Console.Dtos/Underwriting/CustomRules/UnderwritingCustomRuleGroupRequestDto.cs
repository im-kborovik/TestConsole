using System;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRuleGroupRequestDto
    {
        public Guid? ParentId { get; set; }

        public Guid? CompanyId { get; set; }
        
        public string Name { get; set; }
        
        public int Order { get; set; }
    }
}