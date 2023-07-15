using System;
using FinalProject;

class Program
{
    private static readonly CountryHandler _countryHandler = new CountryHandler();
    private static readonly FinalProject.File _file = new FinalProject.File();
    private static List<Product> _products = new List<Product>();

    private const string FILENAME = "products.txt";

    static void Main(string[] args)
    {
        string option = string.Empty;
        Console.Clear();

        while (option != "6")
        {
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1. Calculate shipping");
            Console.WriteLine("2. Save shipments");
            Console.WriteLine("3. Load shipments");
            Console.WriteLine("4. List shipments");
            Console.WriteLine("5. makes payment");
            Console.WriteLine("6. Quit\n");

            Console.Write("Please, select a choice from the menu: ");
            option = Console.ReadLine();
            double totalCost = 0;
            Console.Clear();

            switch (option)
            {
                case "1":
                    string productType = SelectProductType();
                    Country origin = SelectOrigin();
                    Country destination = SelectDestination();
                    string transportType = SelectTransportType();
                    string deliveryType = SelectDeliveryType();

                    Console.Write("Please, enter the weight (Kg) minimum value 1: ");
                    double weight = double.Parse(Console.ReadLine());

                    var transport = TransportFactory.CreateTransport(transportType, deliveryType);

                    if (productType.Equals("Documents"))
                    {
                        var documentProduct = new DocumentProduct(weight, origin, destination, transport);
                        documentProduct.CalculateShipping();
                        totalCost = documentProduct.GetTotalCost();
                        Console.WriteLine(documentProduct.DisplayShippingDescription());
                        ProceedWithPayment(totalCost, documentProduct);
                        _products.Add(documentProduct);
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
                        totalCost = boxProduct.GetTotalCost();
                        Console.WriteLine(boxProduct.DisplayShippingDescription());
                        ProceedWithPayment(totalCost, boxProduct);
                        _products.Add(boxProduct);
                    }

                    break;
                case "2":
                    _file.SaveToFile(FILENAME, _products);
                    Console.WriteLine("Your shipments have been saved !!!\n");

                    break;
                case "3":
                    _products = _file.LoadFromFile(FILENAME);
                    Console.WriteLine("Your shipments have been loaded !!!\n");

                    break;

                case "4":
                    foreach (var product in _products)
                    {
                        Console.WriteLine(product.DisplayProduct());
                    }
                    Console.WriteLine("============================================================");
                    break;

                case "5":
                    Console.WriteLine("Please select a shipment: ");
                    int index = 0;
                    foreach (var product in _products)
                    {   
                        Console.WriteLine($"[{index}] - {product.DisplayProduct()}");       
                        index++;                 
                    }

                    int shipmentSelected = int.Parse(Console.ReadLine());
                    var productSelected = _products[shipmentSelected];

                    if (productSelected.GetIsPaid())
                    {
                        Console.WriteLine($"This shipment is already paid");   
                    }
                    else
                    {
                        Console.WriteLine(productSelected.DisplayShippingDescription());
                        totalCost = productSelected.GetTotalCost();
                        ProceedWithPayment(totalCost, productSelected);
                    }

                    break;

                case "6":
                    Console.WriteLine("have a good day !!!\n");
                    break;
            }
        }
    }

    private static string SelectDeliveryType()
    {
        Console.WriteLine("Select the delivery type: (If you select the express delivery the time" +
                            " of transportating will be less but the price will be increase): ");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Express");
        string deliveryType = Console.ReadLine();
        Console.Clear();
        return deliveryType;
    }

    private static string SelectTransportType()
    {
        Console.WriteLine("Select the means of transport: ");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Plane");
        string transportType = Console.ReadLine();
        Console.Clear();
        return transportType;
    }

    private static Country SelectDestination()
    {
        Console.WriteLine("Please, Select the destination city (type the code): ");
        _countryHandler.DisplayCountries();
        int destinationCityId = int.Parse(Console.ReadLine());
        var destination = _countryHandler.GetCountry(destinationCityId);
        Console.Clear();
        return destination;
    }

    private static Country SelectOrigin()
    {
        Console.WriteLine("Please, Select the origin city (type the code): ");
        _countryHandler.DisplayCountries();
        int originCityId = int.Parse(Console.ReadLine());
        var origin = _countryHandler.GetCountry(originCityId);
        Console.Clear();
        return origin;
    }

    private static string SelectProductType()
    {
        Console.WriteLine("Select the type of product: ");
        Console.WriteLine("1. Documents");
        Console.WriteLine("2. Box");
        string productType = Console.ReadLine() == "1" ? "Documents" : "Box";
        Console.Clear();
        return productType;
    }

    private static void ProceedWithPayment(double totalCost, Product product)
    {
        Console.WriteLine("Proceed with the payment? (yes/no):");
        string proceedPayment = Console.ReadLine();

        if (proceedPayment == "yes")
        {
            Console.WriteLine("Please select the payment method: ");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. DebitCard");
            Console.WriteLine("3. CreditCard");

            string paymentMethod = Console.ReadLine();

            var payment = PaymentFactory.CreatePayment(paymentMethod);
            payment.ProcessPayment(totalCost);
            payment.DisplayPaymentDescription();
            product.SetIsPaid();
        }
    }
}