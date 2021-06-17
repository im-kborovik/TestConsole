using System.Collections.Generic;

namespace Skynet.Forms.Dtos.DynamicFields
{
    public class DynamicFieldDto
    {
        public string Title { get; set; }

        public IReadOnlyCollection<DynamicFieldValueDto> Values { get; set; }
    }
}