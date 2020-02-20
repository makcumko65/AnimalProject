using Application.DTO;
using FluentValidation;
using System.Linq;

namespace Application.Validators
{
    public class AdminValidator: AbstractValidator<AdminDto>
    {
        public AdminValidator()
        {
            RuleFor(prop => prop.Email).EmailAddress();
            RuleFor(prop => prop.Password).Length(8)
                .Must(pass =>
                {
                    return (pass.FirstOrDefault(ch => char.IsDigit(ch)) != ' ');

                }).WithMessage("Password must include at least one Arabic numerals!")
                .Must(pass =>
                {
                    return (pass.FirstOrDefault(ch => char.IsLetter(ch)) != ' ');
                }).WithMessage("Password must include at least one Latin letter!")
                .Must(pass =>
                {
                    return (pass.FirstOrDefault(ch => char.IsLower(ch)) != ' ');
                }).WithMessage("Password must include at least one lower case letter!")
                .Must(pass =>
                {
                    return (pass.FirstOrDefault(ch => char.IsUpper(ch)) != ' ');
                }).WithMessage("Password must include at least one upper case letter!")
                .Must(pass =>
                {
                    foreach (var ch in pass)
                        if (!char.IsDigit(ch) && !char.IsLetter(ch))
                            return false;
                    return true;
                }).WithMessage("Password must not include any non alphanumeric characters!");
        }
    }
}
