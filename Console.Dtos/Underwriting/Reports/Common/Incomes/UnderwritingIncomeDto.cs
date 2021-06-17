using Skynet.Dtos.Underwriting.Documents;
using Skynet.Shared.Underwriting;

namespace Skynet.Dtos.Underwriting.Reports.Common.Incomes
{
    public class UnderwritingIncomeDto
    {
        public UnderwritingIncomeType IncomeType { get; set; }
        public double? Hours { get; set; }
        public double? HourRate { get; set; }
        public double Amount { get; set; }
        public double MonthlyCalculatedAmount { get; set; }
        public int PaidForDays { get; set; }
        public UnderwritingDocumentDto Document { get; set; }
    }
}
