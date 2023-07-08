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
            if (paymentMethod == "1") //cash
            {
                payment = new CashPayment(0);
            }
            else if (paymentMethod == "2") //debitcard
            {
                payment = new DebitCardPayment(0);
            }
            else //creditcard
            {
                payment = new CreditCardPayment(0);
            }

            return payment;
        }
    }
}