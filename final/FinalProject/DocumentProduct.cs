using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DocumentProduct : Product
    {
        //private double _totalCost;
        public DocumentProduct(int weight, Country origin, Country destination, Transport transport): base(weight, origin, destination, transport)
        {

        }

        public override void CalculateShipping()
        {
            var destinationTax = base.GetDestinationTax();
            var transportCost = _transport.CalculateCost();
            var weightCost = GetWeightCost();
            _totalCost = (transportCost + weightCost) * destinationTax;
        }

        /*public override string DisplayShippingDescription()
        {
            string result = @$"
                Origin: {_origin.GetName()}
                Destination: {_destination.GetName()}
                Destination Tax: {_destination.GetTax()}
                Price: {_totalCost}";

            return result;
        }*/
      
        private int GetWeightCost() => _weight * 18;
    }
}