using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task13.Models
{
    public class Confectionery
    {
        public int IdConfecti { get; set; }
        public string Name { get; set; }
        public int PricePerItem { get; set; }    
        public string Type { get; set; }
        public virtual ICollection<Confectionery_Order> Confectionery_Orders { get; set; }
    }
}
