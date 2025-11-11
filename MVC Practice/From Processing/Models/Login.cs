using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace From_Processing.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(6)]
        public string Password { get; set; }    


    }
}