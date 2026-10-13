namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class QuestionResponse
    {
        public long Id { get; set; }
        public long QuestionPaperId { get; set; }
        public string QuestionNo { get; set; } = string.Empty;
        public long? ParentQuestionId { get; set; }
        public byte[] MaxMarks { get; set; } = Array.Empty<byte>();
        public bool IsOptional { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public byte[]? RowSignature { get; set; }
    }
}
