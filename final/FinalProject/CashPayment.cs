using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CashPayment : Payment
    {
        public CashPayment()
        {
        }

        public override void DisplayPaymentDescription()
        {
            Console.WriteLine("Processing the payment ...");
            Spinner();
            Console.WriteLine("\nThanks for your payment");
            Console.WriteLine();
        }

        public override void ProcessPayment(double cost)
        {
            Console.Write($"Please enter ${double.Round(cost)}: ");
            Console.ReadLine();
        }
    }
}