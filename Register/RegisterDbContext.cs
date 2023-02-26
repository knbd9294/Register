using System.Data.Entity;

namespace Registre
{
    public class RegisterDbContext : DbContext
    {
        public virtual DbSet<info> infoes { get; set; }

        public RegisterDbContext() : base("name=DefaultConnection")
        {
        }
    }
}