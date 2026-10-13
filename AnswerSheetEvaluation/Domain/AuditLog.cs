namespace Domain.Entities;

public class AuditLog
{
    public long Id { get; set; }
    public long? UserId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string EntityName { get; set; } = string.Empty;
    public long? EntityId { get; set; }
    public string? Barcode { get; set; }
    public byte[]? OldValue { get; set; }
    public byte[]? NewValue { get; set; }
    public string? IpAddress { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public long? UpdatedBy { get; set; }
    public byte[]? PrevHash { get; set; }
    public byte[]? RowHash { get; set; }
}