using System;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationIncomeDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid IncomeId { get; set; }

        public Guid PersonId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public IncomeType? IncomeType { get; set; }

        public double? MonthlyIncome { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? EmploymentId { get; set; }

        public ApplicationEmploymentDto Employment { get; set; }
    }
}