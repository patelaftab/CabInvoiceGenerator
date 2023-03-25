using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerateException : Exception
    {
        public enum Type
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
        }
        Type type;
        public InvoiceGenerateException(Type type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
