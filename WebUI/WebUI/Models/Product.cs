namespace WebUI.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Owner { get; set; }
    public string? Description { get; set; }
    public string[] Categories { get; set; } = [];
    public string[] ShopsAvailable { get; set; } = [];
    public int? SupposedPrice { get; set; }
    public int Quantity { get; set; } = 1;
}
