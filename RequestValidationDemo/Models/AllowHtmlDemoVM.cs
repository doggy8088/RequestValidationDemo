using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestValidationDemo.Models
{
    public class AllowHtmlDemoVM
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Reason { get; set; }
    }
}