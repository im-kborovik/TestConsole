using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationInfoDto
    {
        public Guid ApplicationId { get; set; }

        public Guid LoanId { get; set; }

        public LoanPurpose? LoanPurpose { get; set; }

        public string PrimaryBorrowerFullName { get; set; }

        public DateTime LastModified { get; set; }

        public ApplicationAddressDto Address { get; set; }
    }
}