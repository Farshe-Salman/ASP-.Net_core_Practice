using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormProcessingAgain.Models
{
    public class Signin
    {
        [Required (ErrorMessage="LOL")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}