using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlaneTransport : Transport
    {
        public PlaneTransport(string deliveryType) : base(deliveryType){}

        //1: standard
        public override int DeliveryTime() => _deliveryType == "1" ? 5 : 3;
        public override double CalculateCost() => _deliveryType == "1" ? 1200 : 1800;     
    }
}