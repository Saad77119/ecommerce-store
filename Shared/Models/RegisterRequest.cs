using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Shared.Models
{
    public class RegisterRequest
    {

       
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID is requierd")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is requierd")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Need min 6 character")]
        public string password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is requierd")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Confirm Password should match with Password")]
        public string ConfirmPassword { get; set; }
         [Display(Name = "Role")]
        //[Required()]
        public int Roleid { get; set; }
    }
}
