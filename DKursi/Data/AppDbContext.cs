using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DKursi.Data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Data.Entities.User>Users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //string ergi
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VMJQGC3C\\SQLEXPRESS;Initial Catalog=DetyreKursi;Integrated Security=True;TrustServerCertificate=True");
        }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.User.ConfigureForDb(modelBuilder.Entity<Data.Entities.User>());
        }

    }
}
