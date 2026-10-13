namespace Domain.Entities;

public class Evaluation
{
    public long Id { get; set; }
    public long AnswerSheetId { get; set; }
    public long EvaluatorId { get; set; }
    public string Stage { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public byte[]? TotalMarks { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? SubmittedAt { get; set; }
    public int? TimeSpentSeconds { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public long? UpdatedBy { get; set; }
    public byte[]? RowSignature { get; set; }
}