using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class ArgMacroContext : DbContext
    {
        public DbSet<Model.BCRA.MonetaryBase> MonetaryBase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-FMK5R8I;Database=ArgMacro;Trusted_Connection=True;");
            }
        }

    }
}
