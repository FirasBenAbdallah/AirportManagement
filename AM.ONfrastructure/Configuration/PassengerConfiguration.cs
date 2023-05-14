using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AM.INfrastructure.Configuration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName, f =>
            {
                f.Property(pf => pf.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                f.Property(pf => pf.LastName).HasColumnName("PassLastName").IsRequired();
            });
            //builder.HasDiscriminator<String>("IsTraveller")
            //    .HasValue<Traveller>("1")
            //    .HasValue<Staff>("2")
            //    .HasValue<Passenger>("0");
        }
    }
}