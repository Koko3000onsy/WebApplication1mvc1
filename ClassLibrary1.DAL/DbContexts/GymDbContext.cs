using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApplication1mvc1.Models;

namespace WebApplication1mvc1.DbContexts
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
         
        }
        public DbSet<Plan> Plans { get; set; } = null!;
       //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //     optionsBuilder.UseSqlServer("Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True;");
       // }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
