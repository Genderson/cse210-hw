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
        private const double MULTIPLIER = 1.8;

        public BoxProduct(double weight, Country origin, Country destination, Transport transport, double height, double length, double width) : base(weight, origin, destination, transport)
        {
            _height = height;
            _length = length;
            _width = width;
        }

        public BoxProduct(double weight, Country origin, Country destination, Transport transport, double height, double length, double width, double totalCost, bool isAlreadyPaid) : base(weight, origin, destination, transport, totalCost, isAlreadyPaid)
        {

        }

        public override string DisplayProduct()
        {
            string payStatus = _isAlreadyPaid ? "Done" : "Pending";
            return $"Product: Box - Origin:{_origin.GetName()} - Destination:{_destination.GetName()} - Pay:{payStatus}";
        }

        public override void CalculateShipping()
        {
            var destinationTax = base.GetDestinationTax();
            var transportCost = _transport.CalculateCost();
            var volumeCost = GetVolumeCost();
            _totalCost = (transportCost + volumeCost) * destinationTax;
        }

        public override string FormatTextToFile() => $"Box|{_weight}|{_origin.GetCode()}|{_destination.GetCode()}|{_transport.GetType()}|{_transport.GetDeliveryType()}|{_totalCost}|{_isAlreadyPaid}|{_height}|{_length}|{_width}";

        private double GetVolumeCost() => (_height * _width * _length) * MULTIPLIER;
    }
}