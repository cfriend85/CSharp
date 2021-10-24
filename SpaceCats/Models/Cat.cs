using System.ComponentModel.DataAnnotations;
namespace SpaceCats.Models
{
    public class Cat
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = "Breed must be at least two characters!")]
        public string Breed { get; set; }
        
        [Required]
        public string Weapon { get; set; }
        
        [Required]
        public string Image { get; set; }
        
        [MinLength(2, ErrorMessage = "Mortal Enemy must be at least 2 characters!")]
        public string MortalEnemy { get; set; }
        
        [Required]
        [Range(1,9, ErrorMessage = "Number of lives must be between one and nine!")]
        public int Lives { get; set; }
    }
}