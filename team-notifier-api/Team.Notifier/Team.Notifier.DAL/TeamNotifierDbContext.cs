using Microsoft.EntityFrameworkCore;

namespace Team.Notifier.DAL
{
    public class TeamNotifierDbContext : DbContext
    {
        public TeamNotifierDbContext(DbContextOptions options) : 
            base(options)
        {
        }

        public DbSet<Common.Team> Teams { get; set; }
    }
}
