using Product_Management_System.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_Management_System.CustomValidation
{
    public class PasswordMatch : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var obj = validationContext.ObjectInstance as CustomerDTO;
            if( obj.Password!=null && value != null)
            {
                if(value.ToString().Equals(obj.Password))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Both Password dont match");
                }
            }
            else
            {
                return new ValidationResult("Enter Password again");
            }
        }
    }

}