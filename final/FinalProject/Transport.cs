using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Transport
    {
        protected string _deliveryType;

        protected Transport(string deliveryType)
        {
            _deliveryType = deliveryType;
        }

        public string GetDeliveryType() => _deliveryType;
        public abstract int DeliveryTime();
        public abstract double CalculateCost();
    }
}