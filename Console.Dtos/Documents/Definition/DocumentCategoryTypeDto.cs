using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Documents.Definition
{
    public class DocumentCategoryTypeDto
    {
        public Guid DocumentCategoryId { get; set; }
        public List<Guid> DocumentTypeIds { get; set; }
    }
}
