using CrudDemo.Backend.CrudDemo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CrudDemo.Backend.CrudDemo.EFCoreDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
