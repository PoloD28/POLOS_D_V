using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.User
{
    class Program3
    {
        static void Main(string[] args)
        {
            User user = new User("john_doe", "John", "Done", "50");
            user.DisplayUserInfo();
            Console.Write(user);
        }
    }
}
