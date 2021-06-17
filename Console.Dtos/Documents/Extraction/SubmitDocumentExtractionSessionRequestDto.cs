using System.Collections.Generic;

namespace Skynet.Dtos.Documents.Extraction
{
    public class SubmitDocumentExtractionSessionRequestDto : DocumentExtractionSessionDto
    {
        public SubmitDocumentExtractionSessionRequestDto()
        {
            ExtractionFields = new List<DocumentExtractionFieldDto>();
        }

        public List<DocumentExtractionFieldDto> ExtractionFields { get; set; }
    }
}
