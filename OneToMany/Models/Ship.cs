using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OneToMany.Models
{
    public class Ship
    {
        [Key]
        public int ShipId { get; set; }
        [Required]
        public string ShipName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Pirate> Crew { get; set; } //Navigation property for the Pirates on the ship

    }
}