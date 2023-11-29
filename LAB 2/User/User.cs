using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2.User
{
    internal class User
    {
        private string loging;
        private string firstName;
        private string lastName;
        private string age;
        private DateTime DateTimeregistrationDate;

        public User(string login, string firsName, string lastName, string age)
        {
            this.loging = login;
            this.firstName = firsName;
            this.lastName = lastName;
            this.age = age;
            this.DateTimeregistrationDate = DateTime.Now;
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine("Information about the user:");
            Console.WriteLine($"login: {loging}");
            Console.WriteLine($"firstName: {firstName}");
            Console.WriteLine($"lastName: {lastName}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"registrationDate: {DateTimeregistrationDate}");
        }

    }
}
