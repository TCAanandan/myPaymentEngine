using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{
    public class PhysicalProductPayment : IPayment
    {
        private bool GeneratePackageslip()
        {
            Console.WriteLine("Generated Package slip for shipping physical product");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Generated Commssion to agent");
            return true;
        }

        public bool GeneratePayment()
        {
            return GeneratePackageslip();
        }
    }
}
