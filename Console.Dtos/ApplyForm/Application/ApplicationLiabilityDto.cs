using System;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public sealed class ApplicationLiabilityDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid LiabilityId { get; set; }

        public Guid BorrowerId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public LiabilityAccountType? AccountType { get; set; }

        public string CompanyName { get; set; }

        public string AccountNumber { get; set; }

        public double? UnpaidBalance { get; set; }

        public double? MonthlyPayment { get; set; }

        public bool? ToBePaidOffAtOrBeforeClosing { get; set; }

        public LiabilityExpenseType? LiabilityExpenseType { get; set; }

        public LiabilityType Type { get; set; }

        public OwnershipType OwnershipType { get; set; }
    }
}