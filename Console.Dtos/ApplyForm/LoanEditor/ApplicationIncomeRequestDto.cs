using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationIncomeRequestDto
    {
        public Guid PersonId { get; set; }

        public IncomeType? IncomeType { get; set; }

        public double? MonthlyIncome { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        
        public ApplicationEmploymentRequestDto Employment { get; set; }
    }
}