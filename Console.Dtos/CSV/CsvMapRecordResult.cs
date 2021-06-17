namespace Skynet.Dtos.Csv
{
    public class CsvMapRecordResult<TRecord> : ICsvMapRecordResult
    {
        public TRecord Record { get; set; }
        public int RowNumber { get; set; }
        public int[] InvalidColumns { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string[] Data { get; set; }
        object ICsvMapRecordResult.Record => Record;
    }
}