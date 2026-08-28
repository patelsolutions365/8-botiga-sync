using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class SyncCustomers
{
    public long CustomerId { get; set; }

    public int StoreId { get; set; }

    public long LocalId { get; set; }

    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? SourceModifiedAt { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
