using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Form_Validation__Built_in_and_custom_both_.Validation;

namespace Form_Validation__Built_in_and_custom_both_.Models
{
    public class Registration
    {
        [Required]
        [RegularExpression(@"^[A-Za-z .-]+$", ErrorMessage = "Name contain only alphabets,spcaes,.-,")]
        public String Name { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Only alphabet and Number and no space")]
        public String UserName { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]$", ErrorMessage = "ID format must be XX-XXXXX-X")]
        public String ID { get; set; }


        [Required]
        [DateOfBirth]
        public DateTime Dob { get; set; }


        [Required]
        public string Email { get; set; }
    }
}