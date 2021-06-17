using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Skynet.Shared.Expressions
{
    [DebuggerDisplay("{Type} {TypeOfValue} {Value}")]
    public class CriteriaExpressionItem
    {
        public ExpressionType Type { get; set; }

        public string Value { get; set; }

        public string TypeOfValue { get; set; }

        public string ArrayEntity { get; set; }

        public IReadOnlyList<CriteriaExpressionItem> Operands { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is CriteriaExpressionItem))
            {
                return false;
            }

            return ReferenceEquals(this, obj) || Equals((CriteriaExpressionItem)obj);
        }

        public override int GetHashCode()
        {
            var result = HashCode.Combine((int)Type, Value, TypeOfValue);
            if (Operands != null)
            {
                result = Operands.Aggregate(result, HashCode.Combine);
            }

            return result;
        }

        private bool Equals(CriteriaExpressionItem comparedItem)
        {
            var operands1 = Operands == null ? new CriteriaExpressionItem[0] : Operands.ToArray();
            var operands2 = comparedItem.Operands == null ? new CriteriaExpressionItem[0] : comparedItem.Operands.ToArray();

            return Type == comparedItem.Type &&
                Value == comparedItem.Value &&
                TypeOfValue == comparedItem.TypeOfValue &&
                operands1.Length == operands2.Length &&
                Enumerable.Range(0, operands1.Length).All(i => Equals(operands1[i], operands2[i]));
        }
    }
}