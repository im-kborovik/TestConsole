using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.PurchaseAdvice
{
    public  class WarehousePurchaseAdviceDto
    {
        public Guid CompanyId { get; set; }
        public Guid WarehouseBankId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string LoanNumber { get; set; }
        public string Split { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal PaidToPrincipal { get; set; }
        public decimal Fees { get; set; }
        public decimal Interest { get; set; }
        public decimal DepositedToDDA { get; set; }
        public decimal DisbursementAmount { get; set; }
    }
}
