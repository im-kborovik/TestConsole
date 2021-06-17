using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationSubjectPropertyLoanDto
    {
        public Guid LoanId { get; set; }

        public Guid SubjectPropertyId { get; set; }

        public string CreditorName { get; set; }

        public LienType? LienType { get; set; }

        public double? MonthlyPayment { get; set; }

        public double? LoanAmount { get; set; }

        public double? CreditLimit { get; set; }
    }
}