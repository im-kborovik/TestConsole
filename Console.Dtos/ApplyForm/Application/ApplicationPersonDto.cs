using System;
using System.Collections.Generic;
using Skynet.Dtos.ApplyForm.LoanEditor;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Dtos.Common;
using Skynet.Shared.ApplyForm;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationPersonDto :  ITenantDto, IApplicationSubEntityDto
    {
        public Guid PersonId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        [DynamicField("First Name")]
        public string FirstName { get; set; }

        [DynamicField("Middle Name")]
        public string MiddleName { get; set; }

        [DynamicField("Last Name")]
        public string LastName { get; set; }

        [DynamicField("Suffix")]
        public PersonSuffix? Suffix { get; set; }

        [DynamicField("Cell Phone Number")]
        public string CellPhoneNumber { get; set; }

        [DynamicField("Home Phone Number")]
        public string HomePhoneNumber { get; set; }

        [DynamicField("Work Phone Number")]
        public string WorkPhoneNumber { get; set; }

        [DynamicField("Email")]
        public string Email { get; set; }

        [DynamicField("Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [DynamicField("Marital Status")]
        public MaritalStatus? MaritalStatus { get; set; }

        [DynamicField("Social Security Number")]
        public string SocialSecurityNumber { get; set; }

        [DynamicField("Does {0} Live Together")]
        public bool? IsLiveTogether { get; set; }

        [DynamicField("Did {0} Live Together For Two Years Together")]
        public bool? IsLiveTogetherForTwoYears { get; set; }
        
        [DynamicField("Does {0} Has The Same Residences As Primary Person")]
        public bool? IsSameResidencesAsForPerson { get; set; }

        [DynamicField("Citizenship Status")]
        public CitizenshipStatus? CitizenshipStatus { get; set; }

        [DynamicField("Number Of Dependents")]
        public int? NumberOfDependents { get; set; }

        [DynamicField("Age Of Dependents")]
        public string AgeOfDependents { get; set; }

        [DynamicField("Is First Time Home Buyer")]
        public bool? IsFirstTimeHomeBuyer { get; set; }

        public ApplicationDeclarationDto Declarations { get; set; }

        [InstanceDynamicField("Military")]
        public ApplicationMilitaryDto Military { get; set; }

        [InstanceDynamicField("Mailing Address")]
        public ApplicationAddressDto MailingAddress { get; set; }

        public IReadOnlyCollection<ApplicationIncomeDto> Incomes { get; set; }

        public IReadOnlyCollection<ApplicationPropertyDto> Properties { get; set; }

        public IReadOnlyCollection<ApplicationResidenceDto> Residences { get; set; }
    }
}