using System;
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Genre { get; set; }

    public string? Image { get; set; }

    public decimal? Price { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}
