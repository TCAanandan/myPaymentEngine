using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRulesEngine.Payment
{

    public enum PaymentType
    {
        PhysicalProduct = 1,
        Book = 2,
        MembershipActivate = 3,
        MembershipUpgrade = 4,
        Video = 5
    }

    public class FactoryPayment
    {
        public static IPayment GetPaymentObject(int objType)
        {
            IPayment _Ipayment;
            if (objType == PaymentType.PhysicalProduct.GetHashCode())
            {
                _Ipayment = new PhysicalProductPayment();
            }
            else if (objType == PaymentType.Book.GetHashCode())
            {
                _Ipayment = new BookPayment();
            }
            else if (objType == PaymentType.MembershipActivate.GetHashCode())
            {
                _Ipayment = new ActivateMembership();
            }
            else if (objType == PaymentType.MembershipUpgrade.GetHashCode())
            {
                _Ipayment = new UpgradeMembership();
            }
            else if (objType == PaymentType.Video.GetHashCode())
            {
                _Ipayment = new Video();
            }
            else
            {
                _Ipayment = null;
            }
            return _Ipayment;
            
        }
    }
}
