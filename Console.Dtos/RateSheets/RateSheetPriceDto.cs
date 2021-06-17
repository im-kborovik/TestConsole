using System;

namespace Skynet.Dtos.RateSheets
{
    public class RateSheetPriceDto : RateSheetPriceRequestDto
    {
        public Guid RateSheetPriceId { get; set; }

        public Guid RateSheetId { get; set; }

        public bool IsActive { get; set; }
    }
}