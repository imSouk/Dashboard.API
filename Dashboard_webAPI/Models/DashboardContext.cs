using Microsoft.EntityFrameworkCore;

namespace Dashboard_webAPI.Models
{
    public class DashboardContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DashboardContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
