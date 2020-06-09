using System;
using System.Collections.Generic;
using System.Linq;
using Task13.Models;
using Task13.Requests_Responces;

namespace Task13.Services
{
    public class SqlServerDatabaseService : IDatabaseDbService
    {
        private readonly Task13DbContext _context;
        public SqlServerDatabaseService(Task13DbContext context)
        {
            _context = context;
        }
        public List<OrderResponce> GetOrders(NameRequest request)
        {
            var result = new List<OrderResponce>();

            if (request.Name == null)
            {
                var OrderList = _context.Orders.Select(o => new Order
                {
                    IdOrder = o.IdOrder,
                    DateAccepted = o.DateAccepted,
                    DateFinished = o.DateFinished,
                    Notes = o.Notes,
                    IdClient = o.IdClient
                }).ToList();

                for (var i = 0; i < OrderList.Count; i++) 
                {
                    result.Add(new OrderResponce 
                    {
                        IdOrder = OrderList[i].IdOrder,
                        DateAccepted = OrderList[i].DateAccepted,
                        DateFinished = OrderList[i].DateFinished,
                        Notes = OrderList[i].Notes,
                        IdClient = OrderList[i].IdClient
                    });
                }
                return result;
            }
            int IdClient = _context.Customers
                           .Where(c => c.Name == request.Name)
                           .Select(c => c.IdClient).SingleOrDefault();
            if (IdClient == 0)
            {
                return null;
            }
            var list = _context.Orders
                .Where(o => o.IdClient == IdClient)
                .Select(o => new Order
            {
                IdOrder = o.IdOrder,
                DateAccepted = o.DateAccepted,
                DateFinished = o.DateFinished,
                Notes = o.Notes,
                IdClient = o.IdClient

             }).ToList();

            for (var i = 0; i < list.Count; i++)
            {
                result.Add(new OrderResponce
                {
                    IdOrder = list[i].IdOrder,
                    DateAccepted = list[i].DateAccepted,
                    DateFinished = list[i].DateFinished,
                    Notes = list[i].Notes,
                    IdClient = list[i].IdClient
                });
            }
            return result;
        }
        public string AddOrders(int id, AddOrderRequest request)
        {
            var clientExists = _context.Customers.Any(c => c.IdClient == id);
            if (clientExists == false)
            {
                return null;
            }

            var employeeExists = _context.Employees.Any(e => e.IdEmpl == request.IdEmployee);
            if (employeeExists == false)
            {
                return null;
            }
            for (var i = 0; i < request.ConfectioneryRequests.Count; i++)
            {
                var productExists = _context.Confectioneries.Any(c => c.Name == request.ConfectioneryRequests[i].Name);
                if (productExists == false)
                {
                    return null;
                }
            }
            var idOrder = _context.Orders.Max(o => o.IdOrder) + 1;
            _context.Orders.Add(new Order
            {
                //IdOrder = _context.Orders.Max(o => o.IdOrder) + 1,
                DateAccepted = request.DateAccepted,
                DateFinished = DateTime.Now,
                Notes = request.Notes,
                IdClient = id,
                IdEmployee = request.IdEmployee
            });

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }

            for (var i = 0; i < request.ConfectioneryRequests.Count; i++) 
            {
                _context.Confectionery_Orders.Add(new Confectionery_Order
                {
                    IdConfection = _context.Confectioneries.Where(c => c.Name == request.ConfectioneryRequests[i].Name).Select(c => c.IdConfecti).Single(),
                    IdOrder = idOrder,
                    Quantity = request.ConfectioneryRequests[i].Quantity,
                    Notes = request.ConfectioneryRequests[i].Notes
                });
            }

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }
            return "The order has been added to the database.";
        }
    }
}
