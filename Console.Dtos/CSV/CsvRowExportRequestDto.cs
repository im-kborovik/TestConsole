using System;
using System.Collections.Generic;
using System.IO;
using Skynet.Shared.Csv;

namespace Skynet.Dtos.Csv
{
    public class CsvRowExportRequestDto
    {
        public CsvMappingEntityType EntityType { get; set; }
        public Guid EntityId { get; set; }
        public Stream ContentStream { get; set; }
        public bool IsConversionNeeded { get; set; }
        public IEnumerable<int> RowNumbers { get; set; }
    }
}