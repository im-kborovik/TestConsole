namespace Skynet.Shared.Loan.LoanApplication
{
    // Note: values were taken from https://singlefamily.fanniemae.com/media/7896/display
    public enum AssetType
    {
        // Accounts 
        Checking = 1,
        Savings = 2,
        MoneyMarket = 3,
        CertificateOfDeposit = 4,
        MutualFund = 5,
        Stocks = 6,
        StockOptions = 7,
        Bonds = 8,
        Retirement = 9,
        BridgeLoanProceeds = 10,
        IndividualDevelopment = 11,
        Account = 12,
        TrustAccount = 13,
        CashValueOfLifeInsurance = 14,

        // Assets
        ProceedsFromRealEstate = 15,
        ProceedsFromSaleOfNonRealEstateAsset = 16,
        SecuredBorrowedFunds = 17,
        UnsecuredBorrowedFunds = 18,
        Other = 19,

        // Credits
        EarnestMoney = 20,
        EmployerAssistance = 21,
        LotEquity = 22,
        RelocationFunds = 23,
        RentCredit = 24,
        SweatEquity = 25,
        TradeEquity = 26
    }
}