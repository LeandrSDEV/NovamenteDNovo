using Microsoft.EntityFrameworkCore;
using NovamenteDenovo.Models;

namespace NovamenteDenovo.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
    }
}
