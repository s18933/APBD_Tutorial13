using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Configurations;

namespace Task13.Models
{
    public class Task13DbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Confectionery> Confectioneries { get; set; }
        public DbSet<Confectionery_Order> Confectionery_Orders { get; set; }
        public Task13DbContext() { }
        public Task13DbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerEfConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEfConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEfConfiguration());
            modelBuilder.ApplyConfiguration(new ConfectioneryEfConfiguration());
            modelBuilder.ApplyConfiguration(new Confectionery_OrderEfConfiguration());
            modelBuilder.Seed();
        }
    }
}
