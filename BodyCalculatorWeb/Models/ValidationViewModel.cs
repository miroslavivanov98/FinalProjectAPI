using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BodyCalculatorWeb.Models
{
    public class ValidationViewModel
    {
        [Required(ErrorMessage = "Weight is required")]
        [Range(40, 200, ErrorMessage = "Price must be between $40 and $200")]
        public string weight { get; set; }

        [Required(ErrorMessage = "Height is required")]
        [Range(100, 240, ErrorMessage = "Height must be between $100 and $240")]
        public string height { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }

    }
}