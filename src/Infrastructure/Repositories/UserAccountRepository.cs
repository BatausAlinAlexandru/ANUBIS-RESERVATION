using Infrastructure.Data;
using CSharpFunctionalExtensions;
using Domain.Aggregates.UserAggregate.Entities;
using Domain.Aggregates.UserAggregate.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class UserAccountRepository : IUserAccountRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserAccountRepository(ApplicationDbContext applicationDbContext)
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

        public async Task<Result> DeleteUserAccountAsync(Guid idUserAccount)
        {
            try
            {
                var user = await _applicationDbContext.UserAccounts.FindAsync(idUserAccount);
                if (user is not null)
                {
                    _applicationDbContext.UserAccounts.Remove(user);
                    await _applicationDbContext.SaveChangesAsync();
                    return Result.Success();
                }
                return Result.Failure("User not found to delete");
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }

        public async Task<List<UserAccount>> GetAllUserAccountsAsync()
        {
            return await _applicationDbContext.UserAccounts.ToListAsync();
        }

        public async Task<Result<UserAccount>> GetUserAccountByIdAsync(Guid idUserAccount)
        {
            var userAccount = await _applicationDbContext.UserAccounts.FindAsync(idUserAccount);

            return userAccount is not null
                ? Result.Success(userAccount)
                : Result.Failure<UserAccount>("User account not found.");
        }

        public async Task<Result> UpdateUserAccountAsync(Guid idUserAccount, UserAccount newUserAccount)
        {
            try
            {
                var user = await _applicationDbContext.UserAccounts.FindAsync(idUserAccount);
                if (user is not null)
                {
                    user.Email = newUserAccount.Email;
                    user.Password = newUserAccount.Password;
                    return Result.Success();
                }
                return Result.Failure("User account not found when try to update user account.");
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
