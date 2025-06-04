using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DKursi.Core.Data.Entities
{
    public class FaturaProdukti
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public Fatura Fatura { get; set; }

        public int ProduktiId { get; set; }
        public Artikuj Artikuj{ get; set; }

        public int Sasia { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<FaturaProdukti> builder)
        {
            builder.ToTable("FaturaProduktet");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Fatura)
                .WithMany(x => x.Produktet)
                .HasForeignKey(x => x.FaturaId);

            builder.HasOne(x => x.Artikuj)
                .WithMany()
                .HasForeignKey(x => x.ProduktiId);

            builder.Property(x => x.Sasia)
                .IsRequired();
        }
    }

}
