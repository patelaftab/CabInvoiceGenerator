using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenrater = new InvoiceGenerator();
            float fair = invoiceGenrater.CalculateFair(0, 1);
            Console.WriteLine("Fair: " + fair);
            fair = invoiceGenrater.CalculateFair(2, 4);
            Console.WriteLine("Fair: " + fair);
            Ride[] rides = { new Ride(1.0f, 2.0f), new Ride(2.0f, 4.0f) };

            float totalFair = invoiceGenrater.CalculateFair(rides);
            Console.WriteLine(totalFair);
            Console.ReadLine();
        }
    }
}
