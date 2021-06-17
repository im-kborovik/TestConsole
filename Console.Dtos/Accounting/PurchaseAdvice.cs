using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Accounting
{
  
    public class PurchaseAdvice
    {
        
        public string WarehouseAccountId { get; set; }
        public string ClearingAccountId { get; set; }
        
        public bool AdviceExported { get; set; }
        public DateTime FundingDate { get; set; } //This is th
        public string ResultDescription { get; set; }
        public decimal ReconDifference { get; set; }
        public decimal WireDifference { get; set; }
        public decimal AmmountDepositedToDDA { get; set; }
        public decimal SumOfAllRevenuesAndExpenses { get; set; }
        public int LoanNumber { get; set; }
        public string Borrower { get; set; }
        public string BorrowerFullName { get; set; }
        public string LoanType { get; set; }

        public decimal DTLoanAmount { get; set; }
        public decimal DTWireAmount { get; set; }
        public decimal DTBrokerYSP { get; set; }
        public decimal DTNetSellPrice { get; set; }
        public decimal DTAdminFee { get; set; }
        public decimal DTHudFee { get; set; }
        public decimal DTMiscFees { get; set; }
        public decimal DTProcessingFee { get; set; }
        public decimal DTPoints { get; set; }
        public decimal DTInterestEarned { get; set; }
        public decimal DTInterestRate { get; set; }
        public decimal DTPrincipalReduction { get; set; }
        public decimal DTPrincipalReductionPostDisbursement { get; set; } //added 11/12/2012 for Invoice Purposes
        public decimal DTBasePrice { get;set; }
        public decimal DTFirstPayment { get; set; }
        public decimal DTPropertyInspectionWaverFee { get; set; }
        public decimal DTCorrWireFee { get; set; }
        public decimal DTLenderCureCredit { get; set; }
        public decimal DTLenderCompensationDisbursement { get; set; }

        public decimal DTPandI { get; set; }
        public decimal DTTotalImpounds { get; set; }
        public decimal DTPMI { get; set; }
        public decimal DTReqImpoundSetup { get; set; }
        public decimal DTPerDiem { get; set; }
        public DateTime DTFirstPaymentDue { get; set; }
        public DateTime DTFundedDate { get; set; }
        public DateTime? DTCorrespondentCurrentPaymentDueDate { get; set; }
        public int DTAmortizationTerm { get; set; }
       // public Channel DTChannel { get; set; }
        public decimal DTImpoundPayment { get; set; }

        public string DTBorrowerStreetAddress { get; set; }
        public string DTBorrowerCity { get; set; }
        public string DTBorrowerState { get; set; }
        public string DTBorrowerZip { get; set; }

        public decimal FinanceYSP { get; set; }
        public decimal CashYSP { get; set; }
        public decimal HairCut { get; set; }
        public decimal MIP { get; set; }
        public decimal BorrowerEscrows { get; set; }
        
        
        public decimal PAGainOnSale { get; set; }
        public decimal PAPurchasedLoanAmount { get; set;  } // fill
        public decimal PAInvestorFees { get; set; }
        public decimal PAAdjustmentsFeesTotal { get; set; }
        public decimal PAEscrowBalance { get; set; } // fill
        public decimal PAServicePremium { get; set; } // fill
        public decimal PAInterestGainedOrOwed { get; set; }
        public decimal PANetPrice { get; set; } // fill
        public decimal PANetSellPrice { get; set; }
        public decimal PANetFundedAmount { get; set; }
        public decimal PAAmtPaidToPrinciple { get; set; }
        public decimal PAAmtPaidToEscrowsAndOther { get; set; }
        public decimal PAAppraisalFees { get; set; }
        public string PAInvestorLoanNumber { get; set; }
        public DateTime PAFirstDueToInvestor { get; set; } // fill
        public string PAServicerLoanNumber { get; set; }
        public string PAServicerTransferDate { get; set; }


        public string Class { get; set; }
     /*   public WarehouseTransactionSource WHBank { get; set; }
        public InvestorTransactionSource Investor { get; set; }

        private PurchaseAdviceBankStatementAnalysisResultRow _bankStatementInfo { get; set; }
        private QBAccount?  _reconDifferenceAccount { get; set; }
        private QBCustomer  _reconCustomer { get; set; }
        private string      _customMemo { get; set; }
*/
    }
}