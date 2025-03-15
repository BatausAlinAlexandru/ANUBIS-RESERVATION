using Microsoft.EntityFrameworkCore;
using Domain.Aggregates.ReservationAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations.ReservationEntityTypeConfigurations
{
    class ReservationEntityTypeConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");

            builder.HasKey(u => u.Id);


        }
    }
}
