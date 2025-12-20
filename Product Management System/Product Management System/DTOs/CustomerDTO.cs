using Product_Management_System.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_Management_System.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [UniqueUserName]
        [RegularExpression(@"^[a-z]+$", ErrorMessage = "Name Only contains small alphabets)")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [PasswordMatch]
        public string ConformPassword { get; set; }


    }
}