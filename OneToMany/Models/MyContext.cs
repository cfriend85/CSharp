using Microsoft.EntityFrameworkCore;

namespace OneToMany.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Pirate> Pirates { get; set; }
        public DbSet<Ship> Ships { get; set; }
    }
}