using System;
using System.ComponentModel.DataAnnotations;
namespace FirstMVC.Models
{
    public class Pet
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = "Species must be at least 2 characters!")]
        public string Species { get; set; }

        [Required]
        public int Age { get; set; }
    }
}