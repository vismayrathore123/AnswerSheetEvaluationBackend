namespace AnswerSheetEvaluation.DTOs.ResponseDTOs
{
    public class EncryptionKeyInfoResponse
    {
        public int Id { get; set; }
        public short KeyVersion { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? RetiredAt { get; set; }
    }
}
