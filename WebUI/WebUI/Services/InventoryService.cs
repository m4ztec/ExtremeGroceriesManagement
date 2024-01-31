using Microsoft.EntityFrameworkCore;
using System.Data;
using WebUI.Data;

namespace WebUI.Services;

public class InventoryService(ProductDbContext productDb)
{


    public async Task hi()
    {
        var hi = await productDb.Products.Select(a => a).ToListAsync();
    }

}
