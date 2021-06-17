using System;

namespace Skynet.Dtos.Investors
{
    public class InvestorDto : InvestorCreateRequestDto
    {
        public Guid InvestorId { get; set; }
    }
}