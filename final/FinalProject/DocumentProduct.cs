using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DocumentProduct : Product
    {
        public DocumentProduct(double weight, Country origin, Country destination, Transport transport): base(weight, origin, destination, transport)
        {

        }

        public override void CalculateShipping()
        {
            var destinationTax = base.GetDestinationTax();
            var transportCost = _transport.CalculateCost();
            var weightCost = GetWeightCost();
            _totalCost = (transportCost + weightCost) * destinationTax;
        }
      
        private double GetWeightCost() => _weight * 18;
    }
}