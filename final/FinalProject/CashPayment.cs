using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CashPayment : Payment
    {
        public CashPayment(double cost) : base(cost)
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