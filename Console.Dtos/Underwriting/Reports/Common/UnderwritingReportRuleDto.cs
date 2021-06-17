using Skynet.Dtos.Underwriting.Documents;
using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.Reports.Common
{
    public class UnderwritingReportRuleDto
    {
        public string RuleName { get; set; }

        public bool IsValid { get; set; }

        public DateTime Date { get; set; }

        public UnderwritingDocumentDto Document { get; set; }

        public IReadOnlyCollection<UnderwritingAlertDto> UnderwritingAlerts { get; set; }
    }
}
