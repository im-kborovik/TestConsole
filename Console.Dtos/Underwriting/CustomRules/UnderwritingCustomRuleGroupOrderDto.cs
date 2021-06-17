using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRuleGroupOrderDto
    {
        public IReadOnlyDictionary<Guid, int> RuleGroupOrdering { get; set; } 
    }
}