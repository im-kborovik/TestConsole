using System;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.LoanEditor
{
    public class ApplicationAssetRequestDto
    {
        public Guid BorrowerId { get; set; }

        public OwnershipType OwnershipType { get; set; }
        
        public string FinancialInstitution  { get; set; }
        
        public string AccountNumber  { get; set; }
        
        public double? CashOrMarketValue { get; set; }
        
        public AssetType? Type { get; set; }
    }
}