using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
    public class BestRestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Cuisine> Cuisines { get; set; }

        public BestRestaurantContext(DbContextOptions options) : base(options) { }
    }
}