using Microsoft.EntityFrameworkCore;
using SoftExpresTestMVC.Models;

namespace SoftExpresTestMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Fature> Fatures { get; set; }
    }
}
