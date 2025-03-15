using Microsoft.EntityFrameworkCore;
using Recipe_Management.Model;

namespace Recipe_Management.Data
{
    public class FoodRecipeDbContext : DbContext
    {
        public FoodRecipeDbContext(DbContextOptions<FoodRecipeDbContext> options):base(options) { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
