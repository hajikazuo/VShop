﻿using System.ComponentModel.DataAnnotations;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.DTOs;

public class CategoryDTO
{
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MinLength(3)]
    [MaxLength(100)]
    public string? Name { get; set; }
    public ICollection<Product>? Products { get; set; }
}
