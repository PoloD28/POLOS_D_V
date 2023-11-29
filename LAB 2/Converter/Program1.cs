using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(37.0, 40.7, 8.5);
            Console.WriteLine("Conversion from UAH to other currencies:");
            double uahAmount = 1000.0;
            Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToUsd(uahAmount)} USD");
            Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToEur(uahAmount)} EUR");
            Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToPln(uahAmount)} PLN");

            Console.WriteLine("Conversion from other currencies to UAH:");
            double usdAmount = 50.0;
            double eurAmount = 40.0;
            double plnAmount = 200.0;
            Console.WriteLine($"{usdAmount} USD = {converter.ConvertFromUsd(usdAmount)} UAH");
            Console.WriteLine($"{eurAmount} EUR = {converter.ConvertFromEur(eurAmount)} UAH");
            Console.WriteLine($"{plnAmount} PLN = {converter.ConvertFromPln(plnAmount)} UAH");

            Console.Write(converter);
        }
    }
}
