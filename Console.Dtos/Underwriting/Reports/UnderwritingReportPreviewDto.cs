using System;

namespace Skynet.Dtos.Underwriting.Reports
{
    /// <summary>
    /// Represents one of available application report item.
    /// </summary>
    public class UnderwritingReportPreviewDto
    {
        /// <summary>
        /// Report id.
        /// </summary>
        public Guid ReportId { get; set; }
        /// <summary>
        /// Report date.
        /// </summary>
        public DateTime ReportDate { get; set; }
    }
}
