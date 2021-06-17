using System;

namespace Skynet.Dtos.Underwriting.Documents
{
    public class UnderwritingDocumentDto
    {
        public Guid DocumentId { get; set; }
        public string DocumentType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
