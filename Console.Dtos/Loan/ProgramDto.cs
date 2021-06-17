using System;

namespace Skynet.Dtos.Loan
{
    public class ProgramDto
    {
        public Guid ProgramId { get; set; }

        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public string ProgramCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public int LoanTerm { get; set; }

        public int AmortTerm { get; set; }

        public decimal AdjustmentCap { get; set; }

        public decimal SubsequentCap { get; set; }

        public decimal InitialCap { get; set; }

        public bool Assumable { get; set; }

        public bool InterestOnly { get; set; }

        public int RateAdjustmentPeriod { get; set; }

        public int SubsequentRateAdjustmentPeriod { get; set; }

        public string LegacyPortalId { get; set; }
    }
}