using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CreditCardPayment : Payment
    {
        private string _cardOwner;
        private string _securityCode;
        private string _expirationDate;
        private long _cardNumber;

        public CreditCardPayment()
        {
        }

        public override void DisplayPaymentDescription()
        {
            Console.WriteLine("An additional fee of 2.3% will be charged");
            Console.WriteLine("Processing the payment ...");
            Spinner();
            Console.WriteLine($"\nThanks {_cardOwner} for your payment");
            Console.WriteLine();
        }

        public override void ProcessPayment(double cost)
        {
            Console.Write($"Please enter the card owner: ");
            _cardOwner = Console.ReadLine();
            Console.Write($"Please enter the card number: ");
            _cardNumber = long.Parse(Console.ReadLine());
            Console.Write($"Please enter the expiration date (MM/yy): ");
            _expirationDate = Console.ReadLine();    
            Console.Write($"Please enter the security code: ");
            _securityCode = Console.ReadLine();
        }
    }
}