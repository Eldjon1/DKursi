using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DKursi.Core.Data.Entities
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Emri { get; set; }

        public List<Artikuj> Artikull { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Kategoria> builder)
        {
            builder.ToTable("Kategorite");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Emri)
                .IsRequired()
                .HasMaxLength(100);
        }
    }

}
