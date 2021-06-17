using System;

namespace Skynet.Dtos.Accounting
{
    public class AdvanceAnalysisRow
    {
        public bool AdvanceExported { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime PostedDate { get; set; }

        public string ResultDescription { get; set; }
        public string LoanNumber { get; set; }
        public decimal AdvanceTransactionAmount { get; set; }
        public decimal AdvancedFromWharehouse { get; set; }
        public decimal AdvanceDrawnFromDDA { get; set; }
        
        //This comes from not CSV --- its inserted by backend after loading data from legacy system or in future skynet - it is data from LOAN Itself
        public string LDBorrower { get; set; }
        public decimal LDLoanAmount { get; set; }
        public decimal LDWireAmount { get; set; }
        public decimal LDBrokerYSP { get; set; }
        public decimal LDInterestEarned { get; set; }
        public decimal LDReqImpoundSetup { get; set; }
        public string LDChannel { get; set; }
        
        public decimal LDLenderCreditAmount { get; set; }
    }
}