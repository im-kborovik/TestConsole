using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Documents.Bundles
{
    public class DocumentBundleValidationResultDto
    {
        public bool IsAnyDocumentExists { get; set; }
        public IReadOnlyCollection<Guid> MissingMandatoryDocumentTypeIds { get; set; }
    }
}
