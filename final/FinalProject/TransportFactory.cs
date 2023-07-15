using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class TransportFactory
    {
        public static Transport CreateTransport(string transportType, string deliveryType)
        {
            Transport transport = null;
            if (transportType == "1")
            {
                transport = new CarTransport(deliveryType);
            }
            else
            {
                transport = new PlaneTransport(deliveryType);
            }

            return transport;
        }
    }
}