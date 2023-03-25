using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public float Distance;
        public float Time;

        public Ride(float distance, float time)
        {
            Distance = distance;
            Time = time;
        }
    }
}
