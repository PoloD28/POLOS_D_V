using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    using System;

    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }

        public double ConvertToUsd(double amountInUah)
        {
            return amountInUah / usdRate;
        }

        public double ConvertToEur(double amountInUah)
        {
            return amountInUah / eurRate;
        }

        public double ConvertToPln(double amountInUah)
        {
            return amountInUah / plnRate;
        }

        public double ConvertFromUsd(double amountInUsd)
        {
            return amountInUsd * usdRate;
        }

        public double ConvertFromEur(double amountInEur)
        {
            return amountInEur * eurRate;
        }

        public double ConvertFromPln(double amountInPln)
        {
            return amountInPln * plnRate;
        }
    }

    class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void CalculateSalaryAndTax(string position, int experience)
        {
            double salary = 0;
            double tax = 0;

            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Зарплата: {salary}");
            Console.WriteLine($"Податковий збір: {tax}");
        }
    }

    class User
    {
        public string Login { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Логін: {Login}");
            Console.WriteLine($"Ім'я: {FirstName}");
            Console.WriteLine($"Прізвище: {LastName}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
        }
    }

    class Program
    {
        static void Main()
        {
            Address address = new Address();
            address.Index = "02260";
            address.Country = "Україна";
            address.City = "Київ";
            address.Street = "Вулиця Жукова";
            address.House = "22";
            address.Apartment = "2";

            Console.WriteLine("Адреса:");
            Console.WriteLine($"Індекс: {address.Index}");
            Console.WriteLine($"Країна: {address.Country}");
            Console.WriteLine($"Місто: {address.City}");
            Console.WriteLine($"Вулиця: {address.Street}");
            Console.WriteLine($"Будинок: {address.House}");
            Console.WriteLine($"Квартира: {address.Apartment}");

            Converter converter = new Converter(27.5, 33.2, 6.8);
            double amountInUah = 1000;

            Console.WriteLine($"1000 грн у USD: {converter.ConvertToUsd(amountInUah)}");
            Console.WriteLine($"1000 грн у EUR: {converter.ConvertToEur(amountInUah)}");
            Console.WriteLine($"1000 грн у PLN: {converter.ConvertToPln(amountInUah)}");

            Employee employee = new Employee("Тигран", "Дудук");
            employee.CalculateSalaryAndTax("Менеджер", 5);

            User user = new User("user123", "Тигран", "Дудук", 30);
            user.DisplayUserInfo();
        }
    }

}
