using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Skynet.Dtos.RetailRates
{
    public class RetailRateDto
    {
        public Guid Id { get; set; }
        [Required]
        public string ProgramName { get; set; }

        public decimal RateValue { get; set; } // Don't rename to 'Rate' this name is reserved.
        public decimal Points { get; set; }
        public decimal APR { get; set; }
        public decimal ClosingCosts { get; set; }
        [UIHint("ProgramTypeTemplate")]
        public ProgramDto ProgramType { get; set; }
        public int Priority { get; set; }
    }
}
