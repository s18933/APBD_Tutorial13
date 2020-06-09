using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Models;

namespace Task13.Configurations
{
    public class EmployeeEfConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(b => b.IdEmpl);

            builder.Property(b => b.IdEmpl)
                   .IsRequired();

            builder.Property(b => b.Name)
                   .HasMaxLength(50);

            builder.Property(b => b.Surname)
                   .HasMaxLength(60);
        }
    }
}
