using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Accounting
{
    public class AccountingLoanInfo
    {
        public string LoanNum { get; set; }
        public decimal LoanAmt { get; set; }
        public decimal WireAmt { get; set; }
        public string AdvanceExportDate { get; set; }
        public string BorrowLn { get; set; }
        public string BorrowFn { get; set; }

        public string TransactionClass { get; set; }
        public decimal BrokerYSP { get; set; }
        public decimal Interest { get; set; }
        public decimal ReqImpoundsSetup { get; set; }
        public decimal AdvanceTransactionAmount { get; set; }



        public decimal NetSellPrice { get; set; }
        public decimal ProcessingFee { get; set; }
        public decimal Points { get; set; }
        public decimal HudFee { get; set; }
        public decimal MiscFees { get; set; }
        public decimal AdminFee { get; set; }
        public decimal PandI { get; set; }
        public decimal Pmi { get; set; }
        public decimal PrincipalReduction { get; set; }
        public decimal TotalImpounds { get; set; }
        public decimal FirstPayment { get; set; }
        public decimal BasePrice { get; set; }
        public decimal CorrWireFee { get; set; }
        public decimal LenderCureCredit { get; set; }
        public decimal LenderCompensationDisbursement { get; set; }
        public decimal Piw { get; set; }
        public decimal PerDiem { get; set; }
        public decimal IntRate { get; set; }
        public decimal Mip { get; set; }
        public string LoanType { get; set; }

        public string WHBank { get; set; }

        public Channel.Channel ChannelID { get; set; }
        public DateTime? CurrentPaymentDueDate { get; set; }
        public decimal AmortizationTerm { get; set; }
        public decimal PrincipalReductionPostDisbursement { get; set; }
        public decimal ImpoundPayment { get; set; }
        public string StreetAddress { get; set; }
        public string BorrowerCity { get; set; }
        public string BorrowerState { get; set; }
        public string BorrowerZip { get; set; }

        public DateTime? FundingDate { get; set; }
        public DateTime? FirstPaymentDue { get; set; }
        public string Stage { get; set; }
        
        public decimal RetailCreditsToBorrower { get; set; }

    }
}
