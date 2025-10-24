using Microsoft.EntityFrameworkCore;
using StandAutomoveis.Models;

namespace StandAutomoveis.Data
{
    public class ViaturaContext : DbContext
    {
        public ViaturaContext(DbContextOptions<ViaturaContext> options)
            : base(options) { }

        public DbSet<Viatura> Viaturas { get; set; }
    }
}