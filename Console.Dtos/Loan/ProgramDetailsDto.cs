using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Loan
{
    public class ProgramDetailsDto
    {
        public string LoanType { get; set; }

        public decimal LoanTerm { get; set; }

        public string ProgramType { get; set; }

        public bool InterestOnly { get; set; }
    }
}
