using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Models;

namespace Task13.Configurations
{
    public class Confectionery_OrderEfConfiguration : IEntityTypeConfiguration<Confectionery_Order>
    {
        public void Configure(EntityTypeBuilder<Confectionery_Order> builder)
        {
            builder.HasKey(b => new { b.IdConfection, b.IdOrder});

            builder.Property(b => b.IdConfection)
                   .IsRequired();

            builder.Property(b => b.IdOrder)
                   .IsRequired();

            builder.Property(b => b.Notes)
                   .HasMaxLength(255);
        }
    }
}
