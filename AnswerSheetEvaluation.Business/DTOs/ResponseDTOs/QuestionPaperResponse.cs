namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class QuestionPaperResponse
    {

        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? PaperCode { get; set; }
        public byte[] TotalMarks { get; set; } = Array.Empty<byte>();
        public byte[]? PassMarks { get; set; }
        public string? PaperFilePath { get; set; }
        public string Status { get; set; } = string.Empty;
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? RowSignature { get; set; }
    }
}
