using System;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationResidenceDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid ResidenceId { get; set; }

        public Guid PersonId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime? StartOfResidence { get; set; }

        public HousingType? HousingType { get; set; }

        public Guid? AddressId { get; set; }

        public Guid? MortgageLenderId { get; set; }

        public bool IsTaxesIncluded { get; set; }

        public double? TaxesAmount { get; set; }

        public double? InsuranceAmount { get; set; }

        public string CurrentExpenseDescription { get; set; }

        public double? AmountOwed { get; set; }

        public double? AmountOfThePayment { get; set; }

        public double? MonthlyRentAmount { get; set; }

        public Guid? PropertyId { get; set; }

        public ApplicationAddressDto Address { get; set; }
    }
}