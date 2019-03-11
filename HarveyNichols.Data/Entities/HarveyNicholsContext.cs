using Microsoft.EntityFrameworkCore;

namespace HarveyNichols.Data.Entities
{
    public class HarveyNicholsContext : DbContext
    {
        public HarveyNicholsContext(DbContextOptions<HarveyNicholsContext> options) : base(options)
        {
        }

        public DbSet<Products> Product { get; set; }
    }
}
