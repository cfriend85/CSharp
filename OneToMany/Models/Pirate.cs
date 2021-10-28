using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OneToMany.Models
{
    public class Pirate
    {
        [Key]
        public int PirateId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Required]
        public int ShipId { get; set; } //Ship that each pirate lives on
        public Ship Ship { get; set; } //Navigation property for which ship the Pirate belongs to
        public List<Pet> Pets { get; set; } //wont add column to MYSQL
    }
}