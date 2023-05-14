using AM.ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace AM.INfrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=FirasBenAbdallahDB;
                Integrated Security=true"
            );
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Flight>? Flights { get; set; }
        public DbSet<Plane>? Planes { get; set; }
        public DbSet<Passenger>? Passengers { get; set; }
        public DbSet<Staff>? Staff { get; set; }
        public DbSet<Traveller>? Travellers { get; set; }
    }
}
