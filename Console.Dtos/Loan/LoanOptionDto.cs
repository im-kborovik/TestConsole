using System;

namespace Skynet.Dtos.Loan
{
    public class LoanOptionDto
    {
        public Guid ProgramId { get; set; }

        public int LoanPeriod { get; set; }

        public decimal Rate { get; set; }

        public decimal Apr  { get; set; }

        public double Fees  { get; set; }

        public double Cost5Year  { get; set; }

        public double Pmi { get; set; }

        public double PaymentMonth { get; set; }
    }
}