using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress]
        public string LEmail { get; set; }
        
        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)] //This tells it that this is a password not just a string of characters
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters!")]
        public string LPassword { get; set; }
    }
}