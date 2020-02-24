using Application.DTO;
using FluentValidation;

namespace Application.Validators
{
    public class AdminEmailValidator : AbstractValidator<AdminEmailDto>
    {
        public AdminEmailValidator()
        {
            RuleFor(prop => prop.Email).EmailAddress();
        }
    }
}
