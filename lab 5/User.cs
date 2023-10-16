using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Order> PurchaseHistory { get; set; } = new List<Order>();
    }
}
