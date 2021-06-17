using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationSubjectPropertyRequestDto
    {
        public PropertyType? PropertyType { get; set; }

        public OccupancyType? Occupancy { get; set; }

        public long? PropertyValue { get; set; }

        public double? CondoAssociationDues { get; set; }

        public string CondoAssociationName { get; set; }

        public bool MixedUseProperty { get; set; }

        public bool ManufacturedHome { get; set; }

        public bool ApplyOtherLoansOnSubjectProperty { get; set; }

        public bool ApplyRentalIncomeYouWantPurchase { get; set; }

        public decimal? IsMoreOneUnitPrimaryResidenceOrInvestmentPropertyAmount { get; set; }

        public decimal? LenderCalculationAmount { get; set; }
    }
}