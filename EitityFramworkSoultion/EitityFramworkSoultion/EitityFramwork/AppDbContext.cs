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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database=Company ; Trusted_Connection=True ; TrustServerCertificate=True");
        }

    }

}
