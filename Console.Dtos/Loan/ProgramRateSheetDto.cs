using Skynet.Dtos.RateSheets;

namespace Skynet.Dtos.Loan
{
    public class ProgramRateSheetDto
    {
        public ProgramDto Program { get; set; }

        public decimal Coefficient { get; set; }

        public RateSheetPriceDto RateSheetPrice { get; set; }
    }
}