using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class AspNetRoleClaims
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public string? Discriminator { get; set; }

    public bool? IsSync { get; set; }

    public virtual AspNetRoles Role { get; set; } = null!;
}
