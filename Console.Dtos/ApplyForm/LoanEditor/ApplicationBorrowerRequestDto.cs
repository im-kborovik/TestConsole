using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationBorrowerRequestDto
    {
        public Guid ApplicationId { get; set; }
        
        public CreditScore? CreditScore { get; set; }
        
        public bool IsLivedSameTwoYears { get; set; }
        
        public bool IsAssetsJoint { get; set; }
    }
}