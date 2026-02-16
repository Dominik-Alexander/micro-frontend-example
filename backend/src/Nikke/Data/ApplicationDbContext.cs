using Microsoft.EntityFrameworkCore;
using Nikke.Models.Entities;

namespace Nikke.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // Vollständig qualifizierter Typ, um Namenskonflikte mit dem Namespace `Nikke` zu vermeiden.
        public DbSet<global::Nikke.Models.Entities.Nikke> Nikkes { get; set; }
    }
}
