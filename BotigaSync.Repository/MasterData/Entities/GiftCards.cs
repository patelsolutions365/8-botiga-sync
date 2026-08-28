using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class GiftCards
{
    public long GiftCardId { get; set; }

    public string CardCode { get; set; } = null!;

    public decimal Balance { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? CardOrSlip { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsActive { get; set; }

    public int StoreId { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
