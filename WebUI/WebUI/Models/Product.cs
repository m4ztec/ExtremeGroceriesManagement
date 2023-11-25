﻿namespace WebUI.Models;

public class Product
{
public required string Id { get; set; }
public required string Name { get; set; }
public string? Description { get; set; }
public string[] Categories { get; set; } = [];
public string[] ShopsAvailable { get; set; } = [];
public int? SupposedPrice { get; set; }
}
