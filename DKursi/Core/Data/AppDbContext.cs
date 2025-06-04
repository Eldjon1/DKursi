using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DKursi.Core.Data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Data.Entities.User>Users {get; set;}
        public DbSet<Data.Entities.Tavolina> Tavolinat { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //string ergiLaptop
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VMJQGC3C\\SQLEXPRESS;Initial Catalog=DetyreKursi;Integrated Security=True;TrustServerCertificate=True");
            //string ergipc
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.User.ConfigureForDb(modelBuilder.Entity<Data.Entities.User>());
            Data.Entities.Tavolina.ConfigureForDb(modelBuilder.Entity<Data.Entities.Tavolina>());
        }

    }
}
