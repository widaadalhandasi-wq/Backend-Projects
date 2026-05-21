using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork2.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet<Departments> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=EFCOREDB ; Trusted_connection=True;TrustServerCertificate=True;");
        }
    }
}
