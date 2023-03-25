using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        readonly int PER_KM = 10;
        readonly int PER_MINIT = 1;
        public float CalculateFair(float distance, float time)
        {
            if (time == 0)
                throw new InvoiceGenerateException(InvoiceGenerateException.Type.INVALID_TIME, "Invalid Time");
            if (distance == 0)
                throw new InvoiceGenerateException(InvoiceGenerateException.Type.INVALID_DISTANCE, "Invalid Distance");
            float fair = distance * PER_KM + time * PER_MINIT;
            return Math.Max(5, fair);
        }
        public float CalculateFair(Ride[] rides)
        {
            if (rides == null)
                throw new InvoiceGenerateException(InvoiceGenerateException.Type.NULL_RIDES, "Null Rides");

            float totalFair = 0;
            foreach (Ride ride in rides)
                totalFair = totalFair + CalculateFair(ride.Distance, ride.Time);

            return totalFair;
        }
    }
}
