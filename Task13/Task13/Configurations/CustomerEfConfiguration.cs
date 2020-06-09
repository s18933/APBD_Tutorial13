using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Models;

namespace Task13.Configurations
{
    public class CustomerEfConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(b => b.IdClient);

            builder.Property(b => b.IdClient)
                   .IsRequired();

            builder.Property(b => b.Name)
                   .HasMaxLength(50);

            builder.Property(b => b.Surname)
                   .HasMaxLength(60);
        }
    }
}
