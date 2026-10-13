namespace Domain.Entities;

public class QuestionMark
{
    public long Id { get; set; }
    public long EvaluationId { get; set; }
    public long QuestionId { get; set; }
    public byte[] MarksObtained { get; set; } = Array.Empty<byte>();
    public bool IsAttempted { get; set; }
    public string? Remark { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public long? UpdatedBy { get; set; }
    public byte[]? RowSignature { get; set; }
}