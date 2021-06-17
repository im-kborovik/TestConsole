using System;
using System.Collections.Generic;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationSubjectPropertyDto : ITenantDto, IApplicationSubEntityDto
    {
        public Guid SubjectPropertyId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public Guid AddressId { get; set; }

        [DynamicField("Type")]
        public PropertyType? PropertyType { get; set; }

        [DynamicField("Occupancy")]
        public OccupancyType? Occupancy { get; set; }

        [DynamicField("Value")]
        public long? PropertyValue { get; set; }

        [DynamicField("Condo Association Dues")]
        public double? CondoAssociationDues { get; set; }

        [DynamicField("Condo Association Name")]
        public string CondoAssociationName { get; set; }

        [DynamicField("Mixed-Use Property")]
        public bool MixedUseProperty { get; set; }

        [DynamicField("Manufactured Home")]
        public bool ManufacturedHome { get; set; }

        [DynamicField("Expected Monthly Rental Income")]
        public double? ExpectedMonthlyRentalIncome { get; set; }

        [DynamicField("Expected Net Monthly Rental Income")]
        public double? ExpectedNetMonthlyRentalIncome { get; set; }

        [InstanceDynamicField("Address")]
        public ApplicationAddressDto Address { get; set; }

        public IReadOnlyCollection<ApplicationSubjectPropertyLoanDto> SubjectPropertyLoans { get; set; }
    }
}