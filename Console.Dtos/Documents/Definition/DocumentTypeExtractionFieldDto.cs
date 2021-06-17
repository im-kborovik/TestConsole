using System;

namespace Skynet.Dtos.Documents.Definition
{
    public class DocumentTypeExtractionFieldDto
    {
        public Guid DocumentTypeId { get; set; }
        public Guid DocumentFieldTypeId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool KeyField { get; set; }
        public bool RequiredFieldForCompletion { get; set; }
    }

    public class DocumentTypeExtractionFieldDtoResponse : DocumentTypeExtractionFieldDto
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
    }
}
