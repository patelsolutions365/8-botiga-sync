using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class FtpProcessedFile
{
    public long Id { get; set; }

    public int FtpConnectionId { get; set; }

    public string RemoteFileName { get; set; } = null!;

    public long? RemoteSize { get; set; }

    public DateTime? RemoteModified { get; set; }

    public string? LocalPath { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
