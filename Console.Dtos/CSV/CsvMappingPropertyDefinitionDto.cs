using System;

namespace Skynet.Dtos.Csv
{
    public class CsvMappingPropertyDefinitionDto
    {
        public Guid? CsvMappingPropertyDefinitionId { get; set; }
        public Guid CsvMappingDefinitionId { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnIndex { get; set; }
        public string PropertyName { get; set; }
    }
}
