using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DebitCardPayment : Payment
    {
        private string _cardOwner;
        private string _expirationDate;
        private long _cardNumber;

        public DebitCardPayment()
        {
        }

        public override void DisplayPaymentDescription()
        {
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
        }
    }
}