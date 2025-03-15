using CSharpFunctionalExtensions;
using Domain.Aggregates.UserAggregate.Repositories;
using MediatR;

namespace Application.Commands.Auth
{
    public class RegisterUserAccountHandler : IRequestHandler<RegisterUserAccountCommand, Result>
    {
        private readonly IAuthRepository _authRepository;

        public RegisterUserAccountHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<Result> Handle(RegisterUserAccountCommand request, CancellationToken cancellationToken)
        {
            await _authRepository.RegisterUserAccountAsync(request.Email, request.Password);
            return Result.Success();
        }
    }
}
