using System;

namespace Skynet.Dtos.Documents.Extraction
{
    public class DocumentExtractionSessionDto
    {
        public Guid Id { get; set; }
        public Guid DocumentId { get; set; }
        public DateTime SessionStartTime { get; set; }
        public DateTime SessionEndTime { get; set; }
    }
}
