using System;

namespace Skynet.Dtos.Documents.Bundles
{
    public class DocumentBundleDocumentTypeDtoResponse
    {
        public Guid DocumentBundleTypeId { get; set; }
        public Guid DocumentTypeId { get; set; }
        public bool UseLatestVersionOfDocument { get; set; }
        public bool IsMandatory { get; set; }
        public int OrderNumber { get; set; }
    }
}
