using Skynet.Dtos.Underwriting.Reports.Common;
using Skynet.Dtos.Underwriting.Reports.Common.Incomes;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.Reports.Sections.Incomes
{
    /// <summary>
    /// Incomes section of detailed report
    /// </summary>
    public class UnderwritingIncomeSectionDto
    {
        /// <summary>
        /// Verified rules in scope of Income Analysis section.
        /// </summary>
        public IReadOnlyCollection<UnderwritingReportRuleDto> ValidationRules { get; set; }
        /// <summary>
        /// Calculated Qualified through all rules from Income Analysis section.
        /// </summary>
        public IReadOnlyCollection<UnderwritingIncomeDto> QualifiedIncomes { get; set; }
    }
}
