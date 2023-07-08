using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Transport
    {
        protected int _cost;
        protected string _deliveryType;

        protected Transport(string deliveryType)
        {
            _cost = 0;
            _deliveryType = deliveryType;
        }

        public abstract int DeliveryTime();
        public abstract double CalculateCost();
    }
}