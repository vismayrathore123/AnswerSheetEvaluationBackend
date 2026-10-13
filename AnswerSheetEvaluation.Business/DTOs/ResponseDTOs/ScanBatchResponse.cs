namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class ScanBatchResponse
    {
        public long Id { get; set; }
        public long QuestionPaperId { get; set; }
        public long UploadedBy { get; set; }
        public int TotalFiles { get; set; }
        public int SuccessCount { get; set; }
        public int FailedCount { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
