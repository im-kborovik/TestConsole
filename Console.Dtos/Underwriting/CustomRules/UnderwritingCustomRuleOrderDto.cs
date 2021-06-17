using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRuleOrderDto
    {
        public Guid GroupId { get; set; }
        
        public IReadOnlyDictionary<Guid, int> RuleOrdering { get; set; } 
    }
}