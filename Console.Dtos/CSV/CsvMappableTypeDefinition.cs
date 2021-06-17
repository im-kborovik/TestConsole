using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Csv
{
    public class CsvMappableTypeDefinition
    {
        public CsvMappableTypeDefinition(IReadOnlyCollection<CsvMappableFieldDto> fields, Type type)
        {
            Fields = fields;
            Type = type;
        }
        
        public Type Type { get; }
        public IReadOnlyCollection<CsvMappableFieldDto> Fields { get; }
    }
}
