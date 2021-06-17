namespace Skynet.Dtos.Accounting
{
    public class AccountingSettingRequest
    {
        public string LoansPendingSaleAccountId { get; set; }
        public string InterestExpenseWarehouseAccountId { get; set; }
        public string InterestEarnedWarehouseAccountId { get; set; }
        public string CustomerEscrowAccountId { get; set; }
        public string CashLoansPendingSaleAccountId { get; set; }
        public string PrepaidBrokerYSPCashAccountId { get; set; }
        public string PrepaidBrokerYSPFinanceAccountId { get; set; }
        public string AdministrativeFeesAccountId { get; set; }
        public string RetailProcessingFeesAccountId { get; set; }
        public string GainOnSaleAccountId { get; set; }
        public string LoanProductionFeesWarehouseFeeAccountId { get; set; }
        public string LoanProductionFeesInvestorFeeAccountId { get; set; }
        public string AppraisalServicesAccountId { get; set; }
        public string UMIPAccountId { get; set; }
        public string GainOnSaleDiscountPointsAccountId { get; set; }
        public string GainOnSaleMiscFeesAccountId { get; set; }
        public string PrincipalReductionsDueToInvestorAccountId { get; set; }
        public string LoanProductionFeesLenderCureAccountId { get; set; }
        public string LenderCompensationDisbursedAccountId { get; set; }
        public string CorrespondentBaseSRPAccountId { get; set; }
        public string PIWFeeAccountId { get; set; }
        public string PANetGainReconDifferenceAccountId { get; set; }
        public string PAWHBankWireDifferenceAccountId { get; set; }
        public string AccountsPayableCurrentAccountId { get; set; }
        public string BrokerYSPAccountId { get; set; }
        public string LenderCreditsAccountId { get; set; }
        public string FirstPaymentDueAccount { get; set; }
        public string ItemInterestId { get; set; }
        public string ItemBorrowerEscrowId { get; set; }
        public string ItemInsuranceId { get; set; }
        public string ItemPrincipalDue { get; set; }
    }
}