namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class AnnotationResponse
    {
        public long Id { get; set; }
        public long EvaluationId { get; set; }
        public int PageNo { get; set; }
        public string ToolType { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
