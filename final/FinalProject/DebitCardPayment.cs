using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DebitCardPayment : Payment
    {
        private string _cardOwner;
        private int _securityCode;
        private string _expirationDate;
        private long _cardNumber;

        public DebitCardPayment(double cost) : base(cost)
        {
        }

        public override string DisplayPaymentDescription()
        {
            throw new NotImplementedException();
        }

        public override void RecordPayment()
        {
            throw new NotImplementedException();
        }
    }
}