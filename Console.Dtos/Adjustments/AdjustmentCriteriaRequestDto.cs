using Skynet.Dtos.CriteriaTree;
using Skynet.Shared.Adjustments;

namespace Skynet.Dtos.Adjustments
{
    public class AdjustmentCriteriaRequestDto : CriteriaTreeNodeBaseDto
    {
        public double Amount { get; set; }

        public AdjustmentType AdjustmentType { get; set; }

        public AdjustmentAmountType AdjustmentAmountType { get; set; }
    }
}