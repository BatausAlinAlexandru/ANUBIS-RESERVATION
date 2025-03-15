using Microsoft.EntityFrameworkCore;
using Domain.Aggregates.SeatAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations.SeatEntityTypeConfigurations
{
    class SeatEntityTypeConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seat");

            builder.HasKey(u => u.Id);
        }
    }
}
