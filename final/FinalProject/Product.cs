using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Product
    {
        protected double _weight;
        protected Country _origin;
        protected Country _destination;
        protected Transport _transport;
        protected double _totalCost;
        protected bool _isAlreadyPaid;

        public Product(double weight, Country origin, Country destination, Transport transport)
        {
            _weight = weight;
            _origin = origin;
            _destination = destination;
            _transport = transport;
            _isAlreadyPaid = false;
        }

        public Product(double weight, Country origin, Country destination, Transport transport, double totalCost, bool isAlreadyPaid)
        {
            _weight = weight;
            _origin = origin;
            _destination = destination;
            _transport = transport;
            _totalCost = totalCost;
            _isAlreadyPaid = isAlreadyPaid;
        }

        public bool GetIsPaid() => _isAlreadyPaid;
        public void SetIsPaid() => _isAlreadyPaid = true;
        public virtual double GetDestinationTax() => _origin != _destination  ? _destination.GetTax() : 1;
        public virtual string DisplayShippingDescription()        
        {
            string result = @$"
                Delivery summary:
                Origin: {_origin.GetName()}
                Destination: {_destination.GetName()}
                Destination Tax: {_destination.GetTax()}
                Price: ${double.Round(_totalCost)}
                Delivery time: {_transport.DeliveryTime()} days";
            return result;
        }
        public virtual double GetTotalCost() => _totalCost;      

        public abstract string DisplayProduct();
        public abstract void CalculateShipping();
        public abstract string FormatTextToFile();
    }
}