using System.Xml.Linq;

namespace WebUI.Models;

public class InventoryProduct : Product
{
    public InventoryProduct() { }

    public InventoryProduct(Product product)
    {
        Id = product.Id;
        Name = product.Name;
        Owner = product.Owner;
        Description = product.Description;
        Categories = product.Categories;
        ShopsAvailable = product.ShopsAvailable;
        SupposedPrice = product.SupposedPrice;
        Quantity = product.Quantity;
    }
}
