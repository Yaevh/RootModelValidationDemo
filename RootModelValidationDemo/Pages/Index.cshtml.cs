using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RootModelValidationDemo.Validation;

namespace RootModelValidationDemo.Pages
{
    [BindProperties]
    [CustomValidator]
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // never gets hit, even if Name is invalid
                return Page();
            }
            return Page();
        }


        public class Validator : AbstractValidator<IndexModel>
        {
            public Validator()
            {
                RuleFor(x => x.Name).Must(x => x.StartsWith("qwerty")).WithMessage("Name must start with \"qwerty\"");
            }

            public override ValidationResult Validate(ValidationContext<IndexModel> context)
            {
                return base.Validate(context); // never gets executed
            }

            public override Task<ValidationResult> ValidateAsync(ValidationContext<IndexModel> context, CancellationToken cancellation = default(CancellationToken))
            {
                return base.ValidateAsync(context, cancellation); // never gets executed
            }
        }
    }
}
