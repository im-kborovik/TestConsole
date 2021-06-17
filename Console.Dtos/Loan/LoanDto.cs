using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.Loan
{
    public class LoanDto
    {
        public Guid LoanId { get; set; }

        public Guid? ApplicationId { get; set; }
        
        public Guid CompanyId { get; set; }
        
        public long? OldLoanNumber { get; set; }
        
        public ApplicationStatus ApplicationStatus { get; set; }
    }
}
