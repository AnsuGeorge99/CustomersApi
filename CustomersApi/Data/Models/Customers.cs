using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Data.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="*This field is required")]
        [StringLength(50, ErrorMessage = "FirstName is too long")]
        [Display(Name = "FirstName")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "*This field is required")]
        [StringLength(50, ErrorMessage = "LastName is too long")]
        [Display(Name = "LastName")]
        public string lastname { get; set; }
        [Required(ErrorMessage = "*This field is required")]
        [Display(Name = "Age")]
        public int age { get; set; }
        [Required(ErrorMessage = "*This field is required")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        [Display(Name = "DOB")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "*This field is required")]
        [StringLength(50, ErrorMessage = "Address is too long")]
        [Display(Name = "Address")]
        public string address { get; set; }
    }
}
