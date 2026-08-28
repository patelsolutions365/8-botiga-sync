using BotigaSync.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BotigaSync.Repository.MasterData;

public partial class MasterBotigaDataContext
{
    public DbSet<SyncInbox> SyncInboxes => Set<SyncInbox>();

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SyncInbox>(entity =>
        {
            entity.ToTable("SyncInboxes");
            entity.HasKey(x => x.SyncInboxId);
            entity.HasIndex(x => x.EventId).IsUnique();
            entity.Property(x => x.EventType).HasMaxLength(100);
        });
    }
}
