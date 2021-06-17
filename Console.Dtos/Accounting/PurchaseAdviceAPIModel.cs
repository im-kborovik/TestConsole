using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Accounting
{
   public  class PurchaseAdviceAPIModel
    {
        public string loanNum { get; set; }
        public DateTime purchasedByInvestor { get; set; }
        public decimal principalBalance { get; set; }
        public decimal principalPurchased { get; set; }
        public decimal discountPremiumPercent { get; set; }
        public decimal discountPremiumAmount { get; set; }
        public decimal fundingFee { get; set; }
        public decimal taxFee { get; set; }
        public decimal escrowBalance { get; set; }
        public decimal interest { get; set; }
        public DateTime firstDueToInvestor { get; set; }
        public decimal otherFees1 { get; set; }
        public decimal otherFees2 { get; set; }
        public decimal otherFees3 { get; set; }
        public decimal otherFees4 { get; set; }
        public decimal otherFees5 { get; set; }
        public decimal servicePremium { get; set; }
        public string investorLoanNumber { get; set; }
        public string serviceLoanNumber { get; set; }
        public string serviceTransferDate { get; set; }
    }
}
