using CSharpFunctionalExtensions;
using Domain.Aggregates.UserAggregate.Entities;

namespace Domain.Aggregates.UserAggregate.Repositories
{
    public interface IAuthRepository
    {
        Task<Result> RegisterUserAccountAsync(string email, string password);
    }
}
