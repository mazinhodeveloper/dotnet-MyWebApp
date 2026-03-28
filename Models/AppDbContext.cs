using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // ✔️ Correct: plural
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ✔️ Map to real SQL table (singular)
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}