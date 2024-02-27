using System;
using System.Collections.Generic;

namespace GroovyBooksApp.Models;

public partial class Cart
{
    public int OrderId { get; set; }

    public int? Quantity { get; set; }

    public int? TotalCost { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
