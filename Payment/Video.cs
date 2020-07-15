using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{
    class Video : IPayment
    {
        private bool GenerateVideoPackagingSlip()
        {
            Console.WriteLine("Generated Package slip for video");
            return this.AddFreeVideotoPackagingSlip();
        }

        private bool AddFreeVideotoPackagingSlip()
        {
            Console.WriteLine("Added free First Aid video on Packaging slip");
            return true;
        }
        public bool GeneratePayment()
        {
            return GenerateVideoPackagingSlip();
        }
    }
}
