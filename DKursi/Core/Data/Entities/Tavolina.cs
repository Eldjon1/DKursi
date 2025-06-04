using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DKursi.Core.Data.Entities
{
    public class Tavolina
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static void ConfigureForDb(EntityTypeBuilder<Tavolina> builder)
        {
            builder.ToTable("Tavolina");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }

}
