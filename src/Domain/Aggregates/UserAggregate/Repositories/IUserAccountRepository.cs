using CSharpFunctionalExtensions;
using Domain.Aggregates.UserAggregate.Entities;

namespace Domain.Aggregates.UserAggregate.Repository
{
    public interface IUserAccountRepository
    {
        public Task<Result> UpdateUserAccountAsync(Guid idUserAccount, UserAccount newUserAccount);
        public Task<Result> DeleteUserAccountAsync(Guid idUserAccount);
        public Task<Result<UserAccount>> GetUserAccountByIdAsync(Guid idUserAccount);
        public Task<List<UserAccount>> GetAllUserAccountsAsync();
    }
}
