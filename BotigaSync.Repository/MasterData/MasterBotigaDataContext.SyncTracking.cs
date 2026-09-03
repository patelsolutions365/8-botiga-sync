using BotigaSync.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BotigaSync.Repository.MasterData;

public partial class MasterBotigaDataContext
{
    public DbSet<SyncInbox> SyncInboxes => Set<SyncInbox>();
    public DbSet<SyncOutbox> SyncOutboxes => Set<SyncOutbox>();

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SyncInbox>(entity =>
        {
            entity.ToTable("SyncInboxes");
            entity.HasKey(x => x.SyncInboxId);
            entity.HasIndex(x => x.EventId).IsUnique();
            entity.Property(x => x.EventType).HasMaxLength(100);
        });

        // Pre-existing table (see dbo.SyncOutboxes) - mapping only, no schema
        // changes are made from here.
        modelBuilder.Entity<SyncOutbox>(entity =>
        {
            entity.ToTable("SyncOutboxes");
            entity.HasKey(x => x.SyncOutboxId);
            entity.HasIndex(x => x.EventId).IsUnique();
        });
    }
}
