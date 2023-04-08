﻿using System;
using System.Collections.Generic;

namespace QLNH.Entities;

public partial class Menu
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? Summary { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<MenuDish> MenuDishes { get; } = new List<MenuDish>();
}
