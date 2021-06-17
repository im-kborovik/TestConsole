using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Investors
{
    public class InvestorCreateRequestDto : InvestorRequestDto, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}