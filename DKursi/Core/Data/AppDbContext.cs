using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DKursi.Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Data.Entities.User> Users { get; set; }
        public DbSet<Data.Entities.Tavolina> Tavolinat { get; set; }
        public DbSet<Data.Entities.Fatura> Faturat { get; set; }
        public DbSet<Data.Entities.Artikuj> Artikull { get; set; }
        public DbSet<Data.Entities.FaturaProdukti> FaturaProduktet { get; set; }
        public DbSet<Data.Entities.Kategoria> Kategorite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //string ergiLaptop
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VMJQGC3C\\SQLEXPRESS;Initial Catalog=DetyreKursi;Integrated Security=True;TrustServerCertificate=True");
            //string ergipc
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            //string mikaela
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            //string Eldjon
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            //string Klena
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            //string Juana
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-55AOBVQ\\SQLEXPRESS;Initial Catalog=DESKTOP-55AOBVQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.User.ConfigureForDb(modelBuilder.Entity<Data.Entities.User>());
            Data.Entities.Tavolina.ConfigureForDb(modelBuilder.Entity<Data.Entities.Tavolina>());
            Data.Entities.Fatura.ConfigureForDb(modelBuilder.Entity<Data.Entities.Fatura>());
            Data.Entities.Artikuj.ConfigureForDb(modelBuilder.Entity<Data.Entities.Artikuj>());
            Data.Entities.FaturaProdukti.ConfigureForDb(modelBuilder.Entity<Data.Entities.FaturaProdukti>());
            Data.Entities.Kategoria.ConfigureForDb(modelBuilder.Entity<Data.Entities.Kategoria>());
        }
    }
}

