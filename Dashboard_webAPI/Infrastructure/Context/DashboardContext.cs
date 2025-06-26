using Dashboard_webAPI.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_webAPI.Infrastructure.Context
{
    public class DashboardContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DashboardContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
