using AM.ApplicationCore.Domain;
using AM.INfrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AM.INfrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration())
                        .ApplyConfiguration(new FlightConfiguration())
                        .ApplyConfiguration(new PassengerConfiguration())
                        .ApplyConfiguration(new TicketConfiguration());
            modelBuilder.Entity<Staff>()
                        .ToTable("Staff");
            modelBuilder.Entity<Traveller>()
                        .ToTable("Travellers");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) 
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }
    }
}
