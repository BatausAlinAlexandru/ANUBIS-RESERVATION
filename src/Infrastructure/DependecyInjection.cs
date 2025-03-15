using Domain.Aggregates.UserAggregate.Repositories;
using Domain.Aggregates.UserAggregate.Repository;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer("Server=172.28.144.1, 51433;Database=ReservationDB;User Id=sa;Password=Anubis245!; TrustServerCertificate=true;"));


            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUserAccountRepository, UserAccountRepository>();


            return services;
        }
    }
}
