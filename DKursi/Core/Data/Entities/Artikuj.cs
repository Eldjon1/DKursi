using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DKursi.Core.Data.Entities
{
    public class Artikuj
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public decimal Cmimi { get; set; }
        public int SasiaNeStok { get; set; }
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Artikuj> builder)
        {
            builder.ToTable("Produktet");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Emri)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Cmimi)
                .IsRequired();

            builder.Property(x => x.SasiaNeStok)
                .IsRequired();

            builder.HasOne(x => x.Kategoria)
            .WithMany(k => k.Artikull)
            .HasForeignKey(x => x.KategoriaId);
        }
    }

}
