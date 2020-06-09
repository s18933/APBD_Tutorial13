using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task13.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer 
                { 
                   IdClient = 1,
                   Name = "Frisk",
                   Surname = "TheHuman"
                },
                new Customer
                {
                    IdClient = 2,
                    Name = "Chara",
                    Surname = "Error"
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    IdEmpl = 1,
                    Name = "Muffet",
                    Surname = "TheSpider"
                },
                new Employee
                {
                    IdEmpl = 2,
                    Name = "Sans",
                    Surname = "TheSkeleton"
                }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    IdOrder = 1,
                    DateAccepted = new DateTime(2012, 3, 9, 10, 0, 0),
                    DateFinished = new DateTime(2012, 3, 9, 10, 5, 0),
                    Notes = "For increasing HP",
                    IdClient = 2,
                    IdEmployee = 1
                },
                new Order
                {
                    IdOrder = 2,
                    DateAccepted = new DateTime(2012, 2, 9, 15, 0, 0),
                    DateFinished = new DateTime(2012, 2, 9, 10, 20, 0),
                    Notes = "For placing food on the head",
                    IdClient = 1,
                    IdEmployee = 2
                }
            );
            modelBuilder.Entity<Confectionery>().HasData(
                new Confectionery
                {
                    IdConfecti = 1,
                    Name = "Spider Donut",
                    PricePerItem = 7,
                    Type = "Made with Spider Cider in the batter."
                },
                new Confectionery
                {
                    IdConfecti = 2,
                    Name = "Hot Cat",
                    PricePerItem = 30,
                    Type = "Like a hot dog, but with cat ears."
                }
            );
            modelBuilder.Entity<Confectionery_Order>().HasData(
                new Confectionery_Order
                {
                    IdConfection = 1,
                    IdOrder = 1,
                    Quantity = 2,
                    Notes = "Eat food made by spiders, for spiders, of spiders!"
                },
                new Confectionery_Order
                {
                    IdConfection = 2,
                    IdOrder = 2,
                    Quantity = 30,
                    Notes = "Thirty is just an excessive."
                }
            );
        }
    }
}
