using System.Collections.Generic;
using Skynet.Dtos.Csv;

namespace Skynet.Dtos.Accounting
{
    public class ProcessResult<T>
    {
        public int TotalRecordsCount { get; set; }
        public int SuccessesRecordsCount { get; set; }
        public IReadOnlyCollection<CsvMapRecordResult<T>> Records { get; set; }
        public Dictionary<string, int> Columns { get; set; }
    }
}