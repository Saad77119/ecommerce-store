using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Estore.Shared.Models
{
    public class LoginRequest
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Email Id Required")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        public string password { get; set; }

        [Display(Name = "Remember Me")]
        public bool Rememberme { get; set; }
    }
}
