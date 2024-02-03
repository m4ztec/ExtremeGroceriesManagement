using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Data;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}