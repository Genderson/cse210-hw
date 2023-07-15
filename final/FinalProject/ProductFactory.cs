using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ProductFactory
    {
        public static Product CreateProduct(string[] parameters)
        {
            Product product = null;
            if(parameters[0] == "Documents")
            {
                CountryHandler countryHandler = new CountryHandler();
                Country origin = countryHandler.GetCountry(int.Parse(parameters[2]));
                Country destination = countryHandler.GetCountry(int.Parse(parameters[3]));
                string transportType = parameters[4].Contains("CarTransport") ? "1" : "2";
                Transport transport = TransportFactory.CreateTransport(transportType, parameters[5]);
                product = new DocumentProduct(double.Parse(parameters[1]), origin, destination, transport, double.Parse(parameters[6]), bool.Parse(parameters[7]));
            }
            else
            {
                CountryHandler countryHandler = new CountryHandler();
                Country origin = countryHandler.GetCountry(int.Parse(parameters[2]));
                Country destination = countryHandler.GetCountry(int.Parse(parameters[3]));
                string transportType = parameters[4].Contains("CarTransport") ? "1" : "2";
                Transport transport = TransportFactory.CreateTransport(transportType, parameters[5]);
                product = new BoxProduct(double.Parse(parameters[1]), origin, destination, transport, double.Parse(parameters[8]), double.Parse(parameters[9]), double.Parse(parameters[10]), double.Parse(parameters[6]), bool.Parse(parameters[7]));
            }

            return product;
        }
    }
}