using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RootModelValidationDemo.Validation
{
    public class CustomValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return false; // never gets executed
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return new ValidationResult("Validation error", new[] { "Name" }); // never gets executed
        }
    }
}
