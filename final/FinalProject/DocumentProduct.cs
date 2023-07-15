using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DocumentProduct : Product
    {
        private const double MULTIPLIER = 1.3;
        public DocumentProduct(double weight, Country origin, Country destination, Transport transport): base(weight, origin, destination, transport)
        {

        }

        public DocumentProduct(double weight, Country origin, Country destination, Transport transport, double totalCost, bool isAlreadyPaid) : base(weight, origin, destination, transport, totalCost, isAlreadyPaid)
        {
            
        }

        public override void CalculateShipping()
        {
            var destinationTax = base.GetDestinationTax();
            var transportCost = _transport.CalculateCost();
            var weightCost = GetWeightCost();
            _totalCost = (transportCost + weightCost) * destinationTax;
        }
      
        public override string DisplayProduct()
        {
            string payStatus = _isAlreadyPaid ? "Done" : "Pending";
            return $"Product: Document - Origin:{_origin.GetName()} - Destination:{_destination.GetName()} - Pay:{payStatus}";
        }

        public override string FormatTextToFile() => $"Documents|{_weight}|{_origin.GetCode()}|{_destination.GetCode()}|{_transport.GetType()}|{_transport.GetDeliveryType()}|{_totalCost}|{_isAlreadyPaid}";
        private double GetWeightCost() => _weight * MULTIPLIER;
    }
}