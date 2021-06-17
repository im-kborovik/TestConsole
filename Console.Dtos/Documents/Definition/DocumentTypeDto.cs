using System;

namespace Skynet.Dtos.Documents.Definition
{
    public class DocumentTypeDto
    {
        public string DocumentTypeName { get; set; }
    }

    public class DocumentTypeDtoResponse : DocumentTypeDto
    {
        public Guid DocumentTypeId { get; set; }
    }
}
