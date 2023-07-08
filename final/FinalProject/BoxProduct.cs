using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BoxProduct : Product
    {
        private double _height;
        private double _length;
        private double _width;
        
        public BoxProduct(double weight, Country origin, Country destination, Transport transport, double height, double length, double width): base(weight, origin, destination, transport)
        {
            _height = height;
            _length = length;
            _width = width;
        }

        public override void CalculateShipping()
        {
            var destinationTax = base.GetDestinationTax();
            var transportCost = _transport.CalculateCost();
            var volumeCost = GetVolumeCost();
            _totalCost = (transportCost + volumeCost) * destinationTax;
        }

        private double GetVolumeCost() => (_height * _width * _length) * 27;
    }
}