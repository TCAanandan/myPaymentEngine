using System;
using PaymentRulesEngine.Payment;

namespace PaymentRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 resultValue;
            Console.WriteLine("Please choose any Order type:");
            Console.WriteLine("1: Phyiscal Product\n" +
                              "2: Book\n" +
                              "3: Activate Memebership\n" +
                              "4: Upgrade Memebership\n" +
                              "5: Video\n");
            Console.WriteLine("********************************");
            var UserInput = Console.ReadLine();

            if (Int32.TryParse(UserInput, out resultValue))
            {
                ProcessPaymentOrder(resultValue);
            }
            else
            {
                Console.WriteLine("Please enter a valid Order Type!");
            }
            Console.ReadKey();
        }

        private static void ProcessPaymentOrder(int PaymentType)
        {
            IPayment paymentProcessing = FactoryPayment.GetPaymentObject(PaymentType);
            if (paymentProcessing == null)
            {
                Console.WriteLine("Invalid option!");
            }
            else
            {
                paymentProcessing.GeneratePayment();
            }


        }
    }
}
