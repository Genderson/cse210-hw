using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PlaneTransport : Transport
    {
        private int _additionalCost;
        private float _tax;
        
        public PlaneTransport(string deliveryType) : base(deliveryType){}

        //1: standard
        public override int DeliveryTime() => _deliveryType == "1" ? 5 : 3;
        public override double CalculateCost() => _deliveryType == "1" ? 2000 : 3200;     
    }
}