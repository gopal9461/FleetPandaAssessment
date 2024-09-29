namespace Entities.Models
{
    public class ChangeLog
    {
        //public int ChangeLogId { get; set; }
        public string? TableName { get; set; }
        public int RecordId { get; set; }
        public string? ColumnName { get; set; }
        public string? PreviousValue { get; set; }
        public string? NewValue { get; set; }
        public string? Timestamp { get; set; } = DateTime.Now.ToString();
    }
}
