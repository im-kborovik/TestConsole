using System;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationPropertyDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid PropertyId { get; set; }

        public Guid PersonId { get; set; }

        public Guid ApplicationId { get; set; } 

        public Guid CompanyId { get; set; } 

        public Guid AddressId { get; set; } 

        public bool HasMortgageLoans { get; set; } 

        public double PropertyValue { get; set; } 

        public string CreditorName { get; set; } 

        public double UnpaidBalance { get; set; } 

        public double MonthlyMortgagePayment { get; set; } 

        public bool IsPaidOffAtOrBeforeClosing { get; set; } 

        public double AnnualTaxPayment { get; set; } 

        public double AnnualInsurancePayment { get; set; } 

        public bool IsTaxesIncluded { get; set; } 

        public bool DoesCollectRent { get; set; } 

        public double MonthlyRentalIncome { get; set; } 

        public bool HasAssociationFee { get; set; } 

        public double MonthlyAssociationFee { get; set; } 

        public PropertyType? PropertyType { get; set; } 

        public IntendedOccupancyType? IntendedOccupancy { get; set; } 

        public bool IsSold { get; set; } 

        public bool IsPendingSale { get; set; } 

        public ApplicationAddressDto Address { get; set; } 
    }
}