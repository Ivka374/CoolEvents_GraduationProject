using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CoolEvents_GraduationProject.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Please enter Username")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Password")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 30 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
    }
}
