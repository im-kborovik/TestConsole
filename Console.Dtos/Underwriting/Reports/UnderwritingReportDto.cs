using Skynet.Dtos.Underwriting.Reports.Sections.Incomes;
using System;

namespace Skynet.Dtos.Underwriting.Reports
{
    /// <summary>
    /// Represents detailed report of underwriting process.
    /// </summary>
    public class UnderwritingReportDto
    {
        /// <summary>
        /// Unique identifier of report
        /// </summary>
        public Guid ReportId { get; set; }
        /// <summary>
        /// Report created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Represents incomes section of detailed report
        /// </summary>
        public UnderwritingIncomeSectionDto IncomesSection { get; set; }
    }
}
