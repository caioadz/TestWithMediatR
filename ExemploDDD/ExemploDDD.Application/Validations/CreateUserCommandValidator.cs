using ExemploDDD.Application.Commands;
using FluentValidation;
using FluentValidation.Results;

namespace ExemploDDD.Application.Validations
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).Equal(x => x.PasswordConfirmation)
                .WithMessage("Password confirmation does not match");
        }
    }
}
