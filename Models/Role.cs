using System;
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class Role
{
    public string Id { get; set; } = null!;

    public string? ConcurrencyStamp { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }
}
