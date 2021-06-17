using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Accounting
{
    public class PurchaseAdviceAnalysisRow
    {
        // This comes from CSV
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
        public int LoanNumber { get; set; }
        public DateTime FundingDate { get; set; } //This is the date the loan was purchased by Investor
        public List<decimal> Fees { get; set; }
        
        // Computed on back end
        // Type of Result -- Good / ERror / Etc
        // public ReconResultType ResultType { get; set; }
        // public List<ReconError> ReconErrors { get; set; }
        public string ResultDescription { get; set; }
        public decimal ReconDifference { get; set; }
        public decimal WireDifference { get; set; }
        public decimal AmmountDepositedToDDA { get; set; }
        public decimal SumOfAllRevenuesAndExpenses { get; set; }
        public string Borrower { get; set; }
        public string BorrowerFullName { get; set; }
        public string LoanType { get; set; }
        public decimal FinanceYSP { get; set; }
        public decimal CashYSP { get; set; }
        
        public decimal FinanceRetailCredit { get; set; }
        public decimal CashRetailCredit { get; set; }
        public decimal FinanceInterest { get; set; }
        public decimal CashInterest { get; set; }
        public decimal HairCut { get; set; }
        public decimal MIP { get; set; }
        public decimal BorrowerEscrows { get; set; }

        //This comes from not CSV --- its inserted by backend after loading data from legacy system or in future skynet - it is data from LOAN Itself
        public string LDBorrowerStreetAddress { get; set; }
        public string LDBorrowerCity { get; set; }
        public string LDBorrowerState { get; set; }
        public string LDBorrowerZip { get; set; }

        public decimal LDLoanAmount { get; set; }
        public decimal LDWireAmount { get; set; }
        public decimal LDBrokerYSP { get; set; }
        public decimal LDNetSellPrice { get; set; }
        public decimal LDAdminFee { get; set; }
        public decimal LDHudFee { get; set; }
        public decimal LDMiscFees { get; set; }
        public decimal LDProcessingFee { get; set; }
        public decimal LDPoints { get; set; }
        public decimal LDInterestEarned { get; set; }
        public decimal LDInterestRate { get; set; }
        public decimal LDPrincipalReduction { get; set; }
        public decimal LDPrincipalReductionPostDisbursement { get; set; } //added 11/12/2012 for Invoice Purposes
        public decimal LDBasePrice { get; set; }
        public decimal LDFirstPayment { get; set; }
        public decimal LDPropertyInspectionWaverFee { get; set; }
        public decimal LDCorrWireFee { get; set; }
        public decimal LDLenderCureCredit { get; set; }
        public decimal LDLenderCompensationDisbursement { get; set; }
        public decimal LDPandI { get; set; }
        public decimal LDTotalImpounds { get; set; }
        public decimal LDPMI { get; set; }
        public decimal LDReqImpoundSetup { get; set; }
        public decimal LDPerDiem { get; set; }
        public DateTime LDFirstPaymentDue { get; set; }
        public DateTime LDFundedDate { get; set; }
        public DateTime? LDCorrespondentCurrentPaymentDueDate { get; set; }
        public int LDAmortizationTerm { get; set; }
        public string LDChannel { get; set; }
        public decimal LDImpoundPayment { get; set; }
        public bool LDAdviceExported { get; set; }
        
        public decimal LDPALeaveAmountInEscrow { get; set; }
        
        public decimal LDLenderCreditAmount { get; set; }

        public string CustomNote { get; set; }
        public bool OkToImport { get; set; }
    }
}