using System;
using System.ComponentModel.DataAnnotations;

namespace Skynet.Dtos.LockDesk
{
    public class TradeManagementSettingsDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [UIHint("InvestorTemplate")]
        public InvestorDto Investor { get; set; }
        public decimal Price { get; set; }
    }
}
