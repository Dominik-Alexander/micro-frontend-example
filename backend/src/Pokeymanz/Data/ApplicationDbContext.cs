using Microsoft.EntityFrameworkCore;
using Pokeymanz.Models.Entities;

namespace Pokeymanz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        {
        
        }

        public DbSet<Pokeyman> Pokeymanz { get; set; }
    }
}
