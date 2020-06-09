using System.Collections.Generic;
using Task13.Requests_Responces;

namespace Task13.Services
{
    public interface IDatabaseDbService
    {
        List<OrderResponce> GetOrders(NameRequest request);
        string AddOrders(int id, AddOrderRequest request);
    }
}
