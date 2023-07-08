using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Payment
    {
        protected float _cost;
        
        public abstract void RecordPayment();
        public abstract string DisplayPaymentDescription();        
    }
}