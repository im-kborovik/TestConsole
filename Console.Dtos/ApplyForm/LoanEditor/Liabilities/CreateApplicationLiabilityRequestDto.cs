using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor.Liabilities
{
    public sealed class CreateApplicationLiabilityRequestDto : UpdateApplicationLiabilityRequestDto
    {
        public LiabilityType Type { get; set; }
    }
}