using System;
using System.Collections.Generic;

namespace GroovyBooksApp.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string Stock { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
