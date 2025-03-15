using Microsoft.EntityFrameworkCore;
using Domain.Aggregates.SeatAggregate;
using Domain.Aggregates.ReservationAggregate;
using Domain.Aggregates.UserAggregate.Entities;
using Infrastructure.EntityConfigurations.SeatEntityTypeConfigurations;
using Infrastructure.EntityConfigurations.EventEntityTypeConfigurations;
using Infrastructure.EntityConfigurations.UserAccountEntityTypeConfigurations;
using Infrastructure.EntityConfigurations.ReservationEntityTypeConfigurations;
using Domain.Aggregates.EventAggregate;

namespace Infrastructure.Data
{
    internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<UserAccount> UserAccounts { get; set; } = null!;
        public DbSet<Seat> Seats { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserAccountEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SeatEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EventEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationEntityTypeConfiguration());

        }
    }
}
