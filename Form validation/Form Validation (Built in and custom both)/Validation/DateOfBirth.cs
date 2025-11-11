using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_Validation__Built_in_and_custom_both_.Validation
{
    public class DateOfBirth : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                var today = DateTime.Today;
                var age = today.Year - date.Year;

                if (date > today.AddYears(-age))
                    age--;

                if (age >= 18)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("You must be at least 18 years old.");
            }

            return new ValidationResult($"The {validationContext.DisplayName} field must be a past date.");
        }
    }
}