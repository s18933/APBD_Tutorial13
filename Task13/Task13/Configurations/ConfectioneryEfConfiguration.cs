using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Models;

namespace Task13.Configurations
{
    public class ConfectioneryEfConfiguration : IEntityTypeConfiguration<Confectionery>
    {
        public void Configure(EntityTypeBuilder<Confectionery> builder)
        {
            builder.HasKey(b => b.IdConfecti);

            builder.Property(b => b.IdConfecti)
                   .IsRequired();

            builder.Property(b => b.Name)
                   .HasMaxLength(200);

            builder.Property(b => b.Type)
                   .HasMaxLength(40);
        }
    }
}
