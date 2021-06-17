using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor.Liabilities
{
    public class UpdateApplicationLiabilityRequestDto
    {
        public Guid BorrowerId { get; set; }
        
        public LiabilityAccountType? AccountType { get; set; }

        public string CompanyName { get; set; }

        public string AccountNumber { get; set; }

        public double? UnpaidBalance { get; set; }

        public double? MonthlyPayment { get; set; }

        public bool? ToBePaidOffAtOrBeforeClosing { get; set; }

        public LiabilityExpenseType? LiabilityExpenseType { get; set; }
        
        public OwnershipType OwnershipType { get; set; }
    }
}