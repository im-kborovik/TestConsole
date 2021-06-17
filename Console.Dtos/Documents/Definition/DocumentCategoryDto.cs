using System;

namespace Skynet.Dtos.Documents.Definition
{
    public class DocumentCategoryDto
    {
        public string DocumentCategoryName { get; set; }
    }

    public class DocumentCategoryDtoResponse : DocumentCategoryDto
    {
        public Guid DocumentCategoryId { get; set; }
        public int OrderNumber { get; set; }
    }
}
