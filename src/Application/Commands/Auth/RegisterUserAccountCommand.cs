using CSharpFunctionalExtensions;
using MediatR;

namespace Application.Commands.Auth
{
    public class RegisterUserAccountCommand : IRequest<Result>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterUserAccountCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
