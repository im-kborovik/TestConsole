using System;

namespace Skynet.Dtos.Accounting
{
    public class LoanAdvance
    {
        public string WarehouseAccountId { get; set; }
        public string ClearingAccountId { get; set; }
        public bool AdvanceExported { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string ResultDescription { get; set; }
        public int LoanNumber { get; set; }
        public string DTBorrower { get; set; }
        public decimal DTLoanAmount { get; set; }
        public decimal DTWireAmount { get; set; }
        public decimal DTBrokerYSP { get; set; }
        public decimal DTInterestEarned { get; set; }
        public decimal DTReqImpountSetup { get; set; }
        public string DTClass { get; set; }

        public decimal AdvanceTransactionAmount { get; set; }
        public decimal AdvancedFromWharehouse { get; set; }
        public decimal AdvanceDrawnFromDDA { get; set; }
    }

}