using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PaymentFactory
    {
        public static Payment CreatePayment(string paymentMethod)
        {
            Payment payment = null;
            if (paymentMethod == "1")
            {
                payment = new CashPayment();
            }
            else if (paymentMethod == "2")
            {
                payment = new DebitCardPayment();
            }
            else
            {
                payment = new CreditCardPayment();
            }

            return payment;
        }
    }
}