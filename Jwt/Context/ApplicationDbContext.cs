using Jwt.Models;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>()
           .HasIndex(u => u.Email)
           .IsUnique(); // Email benzersiz olacak şekilde ayarladık.

            // Custom configuration if needed
        }
    }
   }

