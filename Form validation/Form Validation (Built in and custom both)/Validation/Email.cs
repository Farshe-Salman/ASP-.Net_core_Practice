using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_Validation__Built_in_and_custom_both_.Validation
{
    public class Email : ValidationAttribute
    {
        public Email() { }
    }
}