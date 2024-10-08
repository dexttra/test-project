﻿using System.ComponentModel.DataAnnotations;
using test_project.Models;

public class ProductViewModel
{
    [Required(ErrorMessage = "Введите название продукта")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Введите цену продукта")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть положительным числом")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Введите описание продукта")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Выберите категорию")]
    public CategoryViewModel CategoryViewModel { get; set; } 
}
