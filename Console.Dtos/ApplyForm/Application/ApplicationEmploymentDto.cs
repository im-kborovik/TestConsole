using System;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationEmploymentDto : ITenantDto, IApplicationSubEntityDto
    {
        public Guid EmploymentId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public string EmployerName { get; set; }

        public string PhoneNumber { get; set; }

        public Guid AddressId { get; set; }

        public string PositionOrTitle { get; set; }

        public int? YearsInProfession { get; set; }

        public int? MonthsInProfession { get; set; }

        public EmploymentOwnershipType? EmploymentOwnershipType { get; set; }

        public bool? BusinessOwnerOrSelfEmployed { get; set; }

        public bool? IsEmployedByPartyToTransaction { get; set; }

        #region Gross Monthly Income

        public double? BaseSalary { get; set; }

        public double? Overtime { get; set; }

        public double? Bonus { get; set; }

        public double? Commission { get; set; }

        public double? MilitaryEntitlements { get; set; }

        public double? Other { get; set; }

        #endregion

        public bool IsCurrentlyEmployedHere { get; set; }

        public bool? IsBonusReceived { get; set; }

        public ApplicationAddressDto Address { get; set; }
    }
}