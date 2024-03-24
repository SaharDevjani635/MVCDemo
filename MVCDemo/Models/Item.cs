using System;
using System.Collections.Generic;

namespace MVCDemo.Models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }
}
