using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{
    public interface IPayment
    {
        bool GeneratePayment();
    }
}
