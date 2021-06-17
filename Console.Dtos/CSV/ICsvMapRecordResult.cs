namespace Skynet.Dtos.Csv
{
    public interface ICsvMapRecordResult
    {
        object Record { get; }
        string[] Data { get; set; }
        string ErrorMessage { get; set; }
        bool IsSuccess { get; set; }
        int RowNumber { get; set; }
        int[] InvalidColumns { get; set; }
    }
}