using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomersApi.Data.Models
{
    public class Login
    {
        [Key]
        public int loginId { get; set; }
        [Required(ErrorMessage = "*Username is required")]
        [Display(Name = "Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "*Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
