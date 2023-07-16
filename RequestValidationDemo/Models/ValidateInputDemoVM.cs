using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestValidationDemo.Models
{
    public class ValidateInputDemoVM
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Reason { get; set; }
    }
}