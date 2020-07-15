using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{ 
    class UpgradeMembership : IPayment
    {
        private bool Upgarde_Membership()
        {
            Console.WriteLine("Membership upgraded successfully");
            return EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
            Console.WriteLine("e-mail sent to the owner for Membership Upgrade");
            return true;
        }

        public bool GeneratePayment()
        {
            return Upgarde_Membership();
        }
    }
}
