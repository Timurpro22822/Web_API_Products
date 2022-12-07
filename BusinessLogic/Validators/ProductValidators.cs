using BusinessLogic.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class ProductValidators : AbstractValidator<ProductDTO>
    {
        public ProductValidators()
        {
            int time = DateTime.Now.Year;
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(5, 50);

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .Length(10, 1000);

            RuleFor(x => x.Year)
                .LessThanOrEqualTo(time)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Price).GreaterThanOrEqualTo(10);

            RuleFor(x => x.ImagePath)
                .Must(LinkMustBeAUri)
                .WithMessage("Link '{PropertyValue}' must be a valid URI.");
        }
        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link)) return false;

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
