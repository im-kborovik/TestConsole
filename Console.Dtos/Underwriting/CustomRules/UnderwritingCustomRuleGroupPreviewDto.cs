using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRuleGroupPreviewDto
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }
        
        public string Name { get; set; }

        public int Order { get; set; }

        public IReadOnlyCollection<UnderwritingCustomRulePreviewDto> Rules { get; set; }
    }
}
