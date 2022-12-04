using AuthServer.Core.DTOs;
using FluentValidation;

namespace AuthServer.API.Valitadions
{
    public class CreateUserDtoValidator:AbstractValidator<CreateUserDTO>

    {
        public CreateUserDtoValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email is Required").EmailAddress().WithMessage("Email Format is wrong");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");

            RuleFor(q => q.UserName).NotEmpty().WithMessage("Username is required");
        }
    }
}
