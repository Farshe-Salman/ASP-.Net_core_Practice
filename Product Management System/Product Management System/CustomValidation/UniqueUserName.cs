using Product_Management_System.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_Management_System.CustomValidation
{
    public class UniqueUserName: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PMSEntities db = new PMSEntities();

            if (value != null)
            {
                var uname = (from c in db.Customers
                             where c.UserName.Equals(value.ToString())
                             select c).SingleOrDefault();

                if (uname == null)
                {
                    return ValidationResult.Success;
                }
                else
                    return new ValidationResult("User Name Exists");
            }
            else return new ValidationResult("Check Value");
        }
    }
}