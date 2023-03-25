using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.ReadLine();
        }
    }
}
