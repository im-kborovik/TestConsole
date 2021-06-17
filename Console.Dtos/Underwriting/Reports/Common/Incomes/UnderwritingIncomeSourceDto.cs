using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.Reports.Common.Incomes
{
    public class UnderwritingIncomeSourceDto
    {
        public UnderwritingIncomeSourceDto()
        {
            IncomeItems = new List<UnderwritingIncomeDto>();
        }

        public Guid ReportId { get; set; }
        public IReadOnlyCollection<UnderwritingIncomeDto> IncomeItems { get; set; }
    }
}
