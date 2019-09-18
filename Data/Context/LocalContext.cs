using Microsoft.EntityFrameworkCore;
using MicroService.Model.Base;

namespace MicroService.Data
{
    public class LocalContext : DbContext
    {
        public LocalContext(DbContextOptions options) : base(options) { }
        public DbSet<Config> Config { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
