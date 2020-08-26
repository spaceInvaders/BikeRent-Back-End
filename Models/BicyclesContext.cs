using Microsoft.EntityFrameworkCore;

namespace BikeRent_Back_End.Models
{
    public class BicyclesContext : DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public BicyclesContext(DbContextOptions<BicyclesContext> options) : base(options)
        { }
    }
}
