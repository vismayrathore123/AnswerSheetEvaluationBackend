namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class AnswerSheetResponse
    {
        public long Id { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public long BundleId { get; set; }
        public int SequenceNo { get; set; }
        public long? ScanBatchId { get; set; }
        public int? TotalPages { get; set; }
        public string Status { get; set; } = string.Empty;
        public byte[]? FinalTotalMarks { get; set; }
        public bool IsLocked { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public byte[]? RowSignature { get; set; }
    }
}
