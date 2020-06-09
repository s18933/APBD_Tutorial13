using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task13.Models;

namespace Task13.Requests_Responces
{
    public class AddOrderRequest
    {
        public DateTime DateAccepted { get; set; }
        public string Notes { get; set; }
        public int IdEmployee { get; set; }
        public List<ConfectioneryRequest> ConfectioneryRequests { get; set; }
    }
}
