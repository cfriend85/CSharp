using System;
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        [Required]
        public string PetName { get; set; }
        [Required]
        public string Species { get; set; }
        [MinLength(2, ErrorMessage = "Trick length must be more than 2 characters!")]
        public string Trick { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Required]
        public int PirateId { get; set; }
        public Pirate Owner { get; set; }
    }
}