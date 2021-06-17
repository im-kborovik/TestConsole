using System;
using System.Collections.Generic;
using System.Linq;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    [RootDynamicFieldsDto("Application")]
    public class ApplicationDto
    {
        public Guid ApplicationId { get; set; }

        public Guid? ClientId { get; set; }

        public Guid CompanyId { get; set; }

        [DynamicField("Status")]
        public ApplicationStatus Status { get; set; }

        [DynamicField("Loan Purpose")]
        public LoanPurpose? LoanPurpose { get; set; }

        [DynamicField("Created Date")]
        public DateTime DateCreated { get; set; }

        [DynamicField("Last Modified Date")]
        public DateTime LastModified { get; set; }

        public Guid? LoanId { get; set; }

        public Guid? PrimaryBorrowerId { get; set; }

        [DynamicField("First Mortgage Balance")]
        public long? FirstMortgageBalance { get; set; }

        [DynamicField("Second Mortgage Balance")]
        public long? SecondMortgageBalance { get; set; }

        [DynamicField("Is {0} Second Mortgage Obtained")]
        public bool IsSecondMortgageObtained { get; set; }

        [DynamicField("Is {0} Consent Obtained")]
        public bool IsConsentObtained { get; set; }

        [DynamicField("Is {0} Authorized To Contact")]
        public bool IsAuthorizedToContact { get; set; }

        [DynamicField("Refinance Purpose")]
        public RefinancePurpose? RefinancePurpose { get; set; }

        public Guid SubjectPropertyId { get; set; }

        public Guid? FirstPartProgramId { get; set; }

        public Guid? SecondPartProgramId { get; set; }

        public decimal? FirstPartRate { get; set; }

        public decimal? SecondPartRate { get; set; }

        public decimal? LoanAmount { get; set; }

        public int? NumberOfUnits { get; set; }

        public decimal? AprPart1 { get; set; }

        public decimal? AprPart2 { get; set; }

        public IReadOnlyCollection<ApplicationAddressDto> Addresses { get; set; }

        public IReadOnlyCollection<ApplicationBorrowerDto> Borrowers { get; set; }

        public IReadOnlyCollection<ApplicationTitleHolderDto> TitleHolders { get; set; }

        [InstanceDynamicField("Subject Property")]
        public ApplicationSubjectPropertyDto SubjectProperty { get; set; }

        [InstanceDynamicField("Primary Borrower")]
        public ApplicationBorrowerDto PrimaryBorrower => Borrowers?.FirstOrDefault();

        [InstanceDynamicField("Secondary Borrower")]
        public ApplicationBorrowerDto SecondaryBorrower => Borrowers?.Skip(1).FirstOrDefault();
    }
}