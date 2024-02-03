namespace WebUI.Models;

public class ShoppingListProduct : Product
{
    public ShoppingListProduct() { }

    public ShoppingListProduct(Product product)
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
