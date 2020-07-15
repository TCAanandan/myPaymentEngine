using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{
    public class BookPayment : IPayment
    {
        private bool GenerateDuplicatePackagingSlip()
        {
            Console.WriteLine("Duplicate Package slip generated successfully for royalty department");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Generated Commssion to agent");
            return true;
        }

        public bool GeneratePayment()
        {
            return GenerateDuplicatePackagingSlip();
        }
    }
}
