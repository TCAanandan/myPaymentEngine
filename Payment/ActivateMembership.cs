using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{
    public class ActivateMembership : IPayment
    {
        private bool Activate_Membership()
        {
            Console.WriteLine("Membership activated successfully");
            return this.EmailNotification();
        }

        private bool EmailNotification()
        {
            Console.WriteLine("e-mail sent to the new Member");
            return true;
        }
        public bool GeneratePayment()
        {
            return Activate_Membership();
        }
    }
}
