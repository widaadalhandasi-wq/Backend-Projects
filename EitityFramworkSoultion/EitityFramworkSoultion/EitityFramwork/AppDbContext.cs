using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitityFramwork
{
    internal class AppDbContext : DbContext
    {
        public DbSet<student> Students { get; set; }
        public DbSet<courses> Courses { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Passport> Passport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database=Company ; Trusted_Connection=True ; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .HasOne(s => s.Passport)
                .WithOne(p => p.Student)
                .HasForeignKey<Passport>(p => p.StudentId); // تم الربط هنا بنجاح

            base.OnModelCreating(modelBuilder);
        }
    }

}
