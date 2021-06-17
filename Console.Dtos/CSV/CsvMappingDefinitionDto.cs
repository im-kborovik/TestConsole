using Skynet.Shared.Csv;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Csv
{    
    public class CsvMappingDefinitionUpdateDto
    {
        public Guid CsvMappingDefinitionId { get; set; }
        public string Name { get; set; }        
        public Guid? EntityId { get; set; }
    }

    public class CsvMappingDefinitionCreateDto
    {        
        public Guid CompanyId { get; set; }

        public string Name { get; set; }

        public Guid? EntityId { get; set; }

        public CsvMappingEntityType EntityType { get; set; }
    }

    public class CsvMappingDefinitionDto : CsvMappingDefinitionCreateDto
    {
        public Guid CsvMappingDefinitionId { get; set; }       
    }
}
