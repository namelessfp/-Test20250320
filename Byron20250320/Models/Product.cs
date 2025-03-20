﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Byron20250320.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    public decimal Price { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
