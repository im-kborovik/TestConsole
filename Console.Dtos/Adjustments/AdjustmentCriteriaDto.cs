using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Adjustments
{
    public class AdjustmentCriteriaDto : AdjustmentCriteriaRequestDto, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}