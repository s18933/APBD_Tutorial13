using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task13.Requests_Responces
{
    public class OrderResponce
    {
        public int IdOrder { get; set; }
        public DateTime DateAccepted { get; set; }
        public DateTime DateFinished { get; set; }
        public string Notes { get; set; }
        public int IdClient { get; set; }
    }
}
