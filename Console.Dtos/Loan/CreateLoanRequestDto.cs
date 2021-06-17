using System;

namespace Skynet.Dtos.Loan
{
    public class CreateLoanRequestDto
    {
        public Guid CompanyId { get; set; }

        public long? OldLoanNumber { get; set; }

        public Guid? ApplicationId { get; set; }
    }
}