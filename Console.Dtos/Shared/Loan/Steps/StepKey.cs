using System;

namespace Skynet.Shared.Loan.Steps
{
    public enum StepKey
    {
        TypeOfLoan,
        PropertyType,
        PropertyUsage,
        PropertyAddress,
        PurposeOfRefinance,
        PropertyValue,
        Equity,
        CreditScore,
        PersonalInfo,
        EConsent,
        LoanOptions,
        PrimaryPersonInfo,
        [Obsolete]
        CoBorrowersInfo,
        TitleHoldersInfo,
        CreditProfile,
        CurrentResidence,
        [Obsolete]
        PreviousResidences,
        Reo,
        Income,
        Assets,
        Declarations,
        Review,
        PurchasePrice,
        DownPayment,
        DownPaymentSource
    }
}