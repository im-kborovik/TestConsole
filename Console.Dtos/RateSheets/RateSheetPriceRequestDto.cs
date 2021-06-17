using System;

namespace Skynet.Dtos.RateSheets
{
    public class RateSheetPriceRequestDto
    {
        public Guid ChannelId { get; set; }

        public Guid ProgramId { get; set; }

        public decimal NoteRate { get; set; }

        public decimal Price15Days { get; set; }

        public decimal Price30Days { get; set; }

        public decimal Price45Days { get; set; }

        public decimal Price60Days { get; set; }
    }
}