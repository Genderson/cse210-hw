using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Product
    {
        protected int _weight;
        protected Country _origin;
        protected Country _destination;
        //protected int _totalCost;
        //protected int _deliveryTime;
        protected Transport _transport;
        protected double _totalCost;

        public Product(int weight, Country origin, Country destination, Transport transport)
        {
            _weight = weight;
            _origin = origin;
            _destination = destination;
            _transport = transport;
        }

        public virtual string DisplayShippingDescription()
        {
            string result = @$"
                Origin: {_origin.GetName()}
                Destination: {_destination.GetName()}
                Destination Tax: {_destination.GetTax()}
                Price: {_totalCost}";

            return result;
        }
        public virtual double GetDestinationTax() => _origin != _destination  ? _destination.GetTax() : 1;
        public abstract void CalculateShipping();
    }
}