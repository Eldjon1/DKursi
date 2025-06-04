using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DKursi.Core.Data.Entities
{
    public class Fatura
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int TavolinaId { get; set; }
        public Tavolina Tavolina { get; set; }

        public List<FaturaProdukti> Produktet { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("Faturat");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data)
                .IsRequired();

            builder.HasOne(x => x.Tavolina)
                .WithMany()
                .HasForeignKey(x => x.TavolinaId);
        }
    }

}
