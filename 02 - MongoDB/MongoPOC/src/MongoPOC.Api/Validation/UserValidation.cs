using FluentValidation;
using MongoPOC.Api.Models;

namespace MongoPOC.Api.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            this.CascadeMode = CascadeMode.Stop;

            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Please specify a name")
                .MaximumLength(100)
                .WithMessage("Maximum caracter length is 100");

            RuleFor(m => m.Emails)
                .NotEmpty()
                .WithMessage("Please specify at least one email");

            RuleFor(m => m.Phones)
                .NotEmpty()
                .WithMessage("Please specify at least one phone number");

            RuleForEach(m => m.Emails).ChildRules(emails => {
                emails.RuleFor(m => m.Address).NotEmpty().WithMessage("Please specify an email");
            });

            RuleForEach(m => m.Phones).ChildRules(phones => {
                phones.RuleFor(m => m.Number).NotEmpty().WithMessage("Please specify an phone number");
                phones.RuleFor(m => m.PhoneType).NotEqual(PhoneType.Default);
            });

            RuleFor(m => m.Address).ChildRules(address => {
                address.RuleFor(m => m.Street).NotEmpty().WithMessage("Please specify a street");
                address.RuleFor(m => m.City).NotEmpty().WithMessage("Please specify a city");
                address.RuleFor(m => m.Country).NotEmpty().WithMessage("Please specify a country");
                address.RuleFor(m => m.ZipCode).NotEmpty().WithMessage("Please specify a zip code");
            });
        }
    }
}
