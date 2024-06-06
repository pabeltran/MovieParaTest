using System;
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class CartItem
{
    public int Id { get; set; }

    public string CartId { get; set; } = null!;

    public int? MovieId { get; set; }

    public int? Quantity { get; set; }

    public virtual Movie? Movie { get; set; }
}
