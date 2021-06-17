using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationDeclarationRequestDto
    {
        public Sex? Sex { get; set; }

        public bool OutstandingJudgements { get; set; }

        public bool BankruptInPastSevenYears { get; set; }

        public BankruptType? BankruptType { get; set; }

        public bool PropertyForecloseInPastSevenYears { get; set; }

        public bool PartyToLawSuite { get; set; }

        public bool PresentlyObligatedOnAnyLoanOrDebt { get; set; }

        public bool PartOfDownPaymentBorrowed { get; set; }

        public decimal? PartOfDownPaymentBorrowedAmount { get; set; }

        public bool UsCitizen { get; set; }

        public bool IntendToOccupyPropertyAsPrimaryResidence { get; set; }

        public bool OwnershipInterestPastThreeYears { get; set; }

        public DeclarationPropertyPurpose? PastThreeYearsPropertyPurpose { get; set; }

        public TitleHoldingType? TitleHoldingType { get; set; }

        public bool? RelationshipWithPropertySeller { get; set; }

        public bool LoanOnAnotherProperty { get; set; }

        public bool AnyNewCreditOutsideOfTheLoan { get; set; }

        public bool IsPropertyLien { get; set; }

        public bool PropertyInLieuOfForeclosureInPastSevenYears { get; set; }

        public bool ForeclosureSoldLessOutstandingBalanceWithinPastSevenYears { get; set; }

        public bool GuarantorOnAnyDebtOutsideTheLoan { get; set; }

        public Ethnicity? Ethnicity { get; set; }

        public string EthnicityDescription { get; set; }

        public Race? Race { get; set; }

        public string RaceDescription { get; set; }
    }
}