using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CarTransport : Transport
    {
        public CarTransport(string deliveryType) : base(deliveryType)
        {
        }

        //1: standard
        public override int DeliveryTime() => _deliveryType == "1" ? 10 : 7;
        public override double CalculateCost() => _deliveryType == "1" ? 1000 : 1700;        
    }
}