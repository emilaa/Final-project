
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Models;

namespace Online_Shop___BackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }


    }
}
