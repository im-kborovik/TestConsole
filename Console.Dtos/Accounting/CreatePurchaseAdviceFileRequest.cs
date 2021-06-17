using System;
using System.IO;

namespace Skynet.Dtos.Accounting
{
    public class CreatePurchaseAdviceFileRequest
    {
        public Guid CompanyId { get; set; }
        public Guid InvestorId { get; set; }
        public Guid? UserId { get; set; }
        public Stream ContentStream { get; set; }
        public string Extension { get; set; }
    }
}