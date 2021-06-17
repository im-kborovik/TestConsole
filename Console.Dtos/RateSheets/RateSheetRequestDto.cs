using System;
using System.Collections.Generic;

namespace Skynet.Dtos.RateSheets
{
    public class RateSheetRequestDto
    {
        public string StoragePath { get; set; }

        public string Title { get; set; }

        public Guid ChannelId { get; set; }

        public IReadOnlyCollection<RateSheetPriceRequestDto> RateSheetPrices { get; set; }
    }
}