using System;

namespace Skynet.Dtos.Accounting
{
    public class PurchaseAdviceFileDto
    {
        public Guid PurchaseAdviceFileId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid InvestorId { get; set; }
    }
}