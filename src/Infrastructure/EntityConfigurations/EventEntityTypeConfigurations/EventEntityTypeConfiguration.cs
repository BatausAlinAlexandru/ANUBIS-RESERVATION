using Microsoft.EntityFrameworkCore;
using Domain.Aggregates.EventAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations.EventEntityTypeConfigurations
{
    class EventEntityTypeConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");

            builder.HasKey(u => u.Id);

            builder.HasMany(e => e.Seats)
               .WithOne()
               .HasForeignKey("EventId")
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
