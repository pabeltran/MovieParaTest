using System;
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class UserClaim
{
    public int Id { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public string? UserId { get; set; }
}
