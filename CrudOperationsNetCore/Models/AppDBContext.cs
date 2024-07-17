using Microsoft.EntityFrameworkCore;

namespace CrudOperationsNetCore.Models
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
