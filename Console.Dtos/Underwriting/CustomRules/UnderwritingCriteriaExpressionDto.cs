using Skynet.Shared.Expressions;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.CustomRules
{
    public class UnderwritingCriteriaExpressionDto
    {
        public ExpressionType Type { get; set; }

        public string Value { get; set; }

        public string TypeOfValue { get; set; }
        
        public string ArrayEntity { get; set; }

        public IReadOnlyList<UnderwritingCriteriaExpressionDto> Operands { get; set; }
    }
}
