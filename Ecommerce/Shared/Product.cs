﻿using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Shared;

public  class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    public Category? Category { get; set; }
    public int CategoryId { get; set; }
    public bool Featured { get; set; } = false;
    public List<ProductVariant> Variants { get; set; } = new();
}
