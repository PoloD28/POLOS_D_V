using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
