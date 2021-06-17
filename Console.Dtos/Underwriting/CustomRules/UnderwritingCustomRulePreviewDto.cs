using System;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRulePreviewDto
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }
        
        public string Name { get; set; }

        public int Order { get; set; }

        public bool IsEnabled { get; set; }
    }
}