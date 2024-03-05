using System;
using System.Collections.Generic;

namespace JR_Books_MkII.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string Stock { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
