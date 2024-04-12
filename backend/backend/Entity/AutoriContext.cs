using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class AutoriContext : DbContext
    {
        public AutoriContext(DbContextOptions<AutoriContext> options) : base(options)
        {
        }

        public DbSet<Autori> Autori { get; set; }
    }
}
