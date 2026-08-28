using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class CompanyInformation
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? StoreId { get; set; }

    public string? Website { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public bool? Thriftstore { get; set; }

    public bool? AutoRecycler { get; set; }

    public bool? ShipCompliant { get; set; }

    public decimal? UpperLimitforwinningpayouts { get; set; }

    public decimal? Dailylimitforwinningpayouts { get; set; }

    public decimal? CommissionPrecentageonsales { get; set; }

    public decimal? CommissionPrecentageonpayouts { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
