namespace AnswerSheetEvaluation.DTOs.RequestDTOs
{
    public class BundleRequest
    {
        public long Id { get; set; }
        public string BundleBarcode { get; set; } = string.Empty;
        public long QuestionPaperId { get; set; }
        public int ExpectedCopies { get; set; }
        public int ScannedCopies { get; set; }
        public int? SerialFrom { get; set; }
        public int? SerialTo { get; set; }
        public long? AssignedEvaluatorId { get; set; }
        public string Status { get; set; } = string.Empty;
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
