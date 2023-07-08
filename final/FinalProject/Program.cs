using System;
using FinalProject;

class Program
{
    private static readonly CountryHandler _countryHandler = new CountryHandler();

    static void Main(string[] args)
    {
        string option = string.Empty;
        Console.Clear();

        while (option != "2")
        {
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Calculate shipping");
            /*Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Save Orders");
            Console.WriteLine("4. Load Orders");
            Console.WriteLine("5. List Orders");*/
            Console.WriteLine("2. Quit\n");

            Console.Write("Please, select a choice from the menu: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Select the type of product: ");
                    Console.WriteLine("1. Documents");
                    Console.WriteLine("2. Box");
                    string productType = Console.ReadLine() == "1" ? "Documents" : "Box";

                    Console.WriteLine("Please, Select the origin city (type the code): ");
                    _countryHandler.DisplayCountries();
                    int originCityId = int.Parse(Console.ReadLine());
                    var origin = _countryHandler.GetCountry(originCityId);

                    Console.WriteLine("Please, Select the destination city (type the code): ");
                    _countryHandler.DisplayCountries();
                    int destinationCityId = int.Parse(Console.ReadLine());
                    var destination = _countryHandler.GetCountry(destinationCityId);

                    Console.WriteLine("Select the means of transport: ");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Plane");
                    string transportType = Console.ReadLine();

                    Console.WriteLine(@"
                    Select the delivery type: (If you select the express delivery the time 
                    of transportating will be less but the price will be increase): ");
                    Console.WriteLine("1. Standard");
                    Console.WriteLine("2. Express");
                    string deliveryType = Console.ReadLine();

                    Console.Write("Please, enter the weight (Kg) minimum value 1: ");
                    double weight = double.Parse(Console.ReadLine());

                    var transport = TransportFactory.CreateTransport(transportType, deliveryType);

                    if (productType.Equals("Documents"))
                    {
                        var documentProduct = new DocumentProduct(weight, origin, destination, transport);
                        documentProduct.CalculateShipping();
                        Console.WriteLine(documentProduct.DisplayShippingDescription());
                    }
                    else
                    {
                        Console.Write("Please, enter the height (cm): ");
                        double height = double.Parse(Console.ReadLine());

                        Console.Write("Please, enter the length (cm): ");
                        double length = double.Parse(Console.ReadLine());

                        Console.Write("Please, enter the width (cm): ");
                        double width = double.Parse(Console.ReadLine());

                        var boxProduct = new BoxProduct(weight, origin, destination, transport, height, length, width);
                        boxProduct.CalculateShipping();
                        Console.WriteLine(boxProduct.DisplayShippingDescription());
                    }

                    Console.WriteLine("Proceed with the payment? (yes/no):");
                    string payment = Console.ReadLine();


                    if (payment == "yes")
                    {
                        Console.WriteLine("Please select the payment method: ");
                        Console.WriteLine("1. Cash");
                        Console.WriteLine("2. DebitCard");
                        Console.WriteLine("3. CreditCard");

                        string paymentMethod = Console.ReadLine();

                    }

                    break;

                case "2":
                    Console.WriteLine("have a good day !!!\n");
                    break;
            }
        }
    }
}