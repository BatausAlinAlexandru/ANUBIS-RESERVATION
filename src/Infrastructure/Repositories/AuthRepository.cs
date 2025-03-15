using CSharpFunctionalExtensions;
using Domain.Aggregates.UserAggregate.Entities;
using Domain.Aggregates.UserAggregate.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    internal class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AuthRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Result> RegisterUserAccountAsync(string email, string password)
        {
            try
            {
                _applicationDbContext.UserAccounts.Add(new UserAccount(email, password));
                await _applicationDbContext.SaveChangesAsync();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
