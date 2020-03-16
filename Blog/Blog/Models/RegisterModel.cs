using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set;}
        [DataType(DataType.Password)]
        [Display(Name ="Confir password")]
        [Compare("Password",
            ErrorMessage ="Contraña incorrecta")]
        public string ConfirmPassword { get; set; }
    }
}
