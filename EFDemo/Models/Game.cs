using System;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}