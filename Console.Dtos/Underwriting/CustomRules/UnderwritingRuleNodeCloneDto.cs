using System;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingRuleNodeCloneDto
    {
        public Guid SourceId { get; set; }
        
        public Guid? DestinationId { get; set; }
        
        public string Name { get; set; }
    }
}