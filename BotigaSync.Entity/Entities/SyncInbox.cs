using System.ComponentModel.DataAnnotations;

namespace BotigaSync.Entity.Entities;

public class SyncInbox
{
    [Key]
    public long SyncInboxId { get; set; }
    public Guid EventId { get; set; }
    public int? StoreId { get; set; }
    public string EventType { get; set; } = string.Empty;
    public DateTime ReceivedAt { get; set; } = DateTime.UtcNow;
}
