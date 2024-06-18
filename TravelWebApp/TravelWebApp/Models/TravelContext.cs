using Microsoft.EntityFrameworkCore;

namespace TravelWebApp.Models
{
    public class TravelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Events> Activities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }
    }
}
