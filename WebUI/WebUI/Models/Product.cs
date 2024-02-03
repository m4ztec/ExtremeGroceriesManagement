namespace WebUI.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Owner { get; set; }
    public string? Description { get; set; }
    public int ExistingQuantity { get; set; } = 0;
    public int DesiredQuantity { get; set; } = 1;
    public string[] Categories { get; set; } = [];
    public string[] ShopsAvailable { get; set; } = [];
    public int? SupposedPrice { get; set; }
}
