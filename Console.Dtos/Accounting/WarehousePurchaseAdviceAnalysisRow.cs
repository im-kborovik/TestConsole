using System;
using Skynet.Shared.Csv;

namespace Skynet.Dtos.Accounting
{
    public class WarehousePurchaseAdviceAnalysisRow
    {
        public Guid CompanyId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string LoanNumber { get; set; }
        [NotRequiredPropertyMapping]
        public string Split { get; set; }
        [NotRequiredPropertyMapping]
        public decimal TransactionAmount { get; set; }
        public decimal PaidToPrincipal { get; set; }
        public decimal Fees { get; set; }
        public decimal Interest { get; set; }
        
        public decimal DisbursementAmount { get; set; }
        public decimal DepositedToDDA { get; set; }
    }
}