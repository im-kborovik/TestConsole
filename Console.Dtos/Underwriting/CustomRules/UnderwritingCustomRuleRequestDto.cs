using System;
using System.Collections.Generic;
using Skynet.Dtos.Underwriting.Actions;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCustomRuleRequestDto
    {
        public Guid? ParentId { get; set; }

        public Guid GroupId { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public bool IsEnabled { get; set; } 

        public UnderwritingCriteriaExpressionDto Expression { get; set; }

        public string UserFriendlyExpression { get; set; }

        public IReadOnlyCollection<UnderwritingActionDto> Actions { get; set; }
    }
}