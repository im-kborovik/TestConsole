using System;

namespace Skynet.Dtos.Documents.Definition
{
    public class DocumentFieldTypeDto
    {
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public DocumentFieldTypeTypeDto Type { get; set; }
    }

    public class DocumentFieldTypeDtoResponse : DocumentFieldTypeDto
    {
        public Guid Id { get; set; }
    }
}
