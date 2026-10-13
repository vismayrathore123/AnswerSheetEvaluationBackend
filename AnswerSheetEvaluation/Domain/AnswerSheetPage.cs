namespace Domain.Entities;

public class AnswerSheetPage
{
    public long Id { get; set; }
    public long AnswerSheetId { get; set; }
    public int PageNo { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty;
    public int? Width { get; set; }
    public int? Height { get; set; }
    public int? FileSizeKb { get; set; }
    public string? FileHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public long? UpdatedBy { get; set; }
}