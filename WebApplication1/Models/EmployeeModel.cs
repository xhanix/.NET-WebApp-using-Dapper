using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(100000,999999, ErrorMessage = "You need to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your first name.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Password), StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }
        
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

}