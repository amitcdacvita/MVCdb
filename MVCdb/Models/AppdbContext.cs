using Microsoft.EntityFrameworkCore;

namespace MVCdb.Models
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
