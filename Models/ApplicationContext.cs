using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TestProject.Models
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        internal async Task<IActionResult> FindAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
