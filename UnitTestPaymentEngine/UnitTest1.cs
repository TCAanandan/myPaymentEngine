using PaymentRulesEngine.Payment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestPaymentEngine
{
    

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PaymentFactory_Should_Generate_PackagingSlip_ForPhysicalProduct()
        {
            //Arrange
            int physicalProduct = PaymentType.PhysicalProduct.GetHashCode();
            IPayment paymentObject = FactoryPayment.GetPaymentObject(physicalProduct);
            //Act
            bool result = paymentObject.GeneratePayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Create_DuplicatePackagingSlip_RoyaltyDep_ForBook()
        {
            //Arrange
            int book = PaymentType.Book.GetHashCode();
            IPayment paymentObject = FactoryPayment.GetPaymentObject(book);
            //Act
            bool result = paymentObject.GeneratePayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_ActiavteMembership()
        {
            //Arrange
            int activate = PaymentType.MembershipActivate.GetHashCode();
            IPayment paymentObject = FactoryPayment.GetPaymentObject(activate);
            //Act
            bool result = paymentObject.GeneratePayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_UpgradeMembership()
        {
            //Arrange
            int upgrade = PaymentType.MembershipUpgrade.GetHashCode();
            IPayment paymentObject = FactoryPayment.GetPaymentObject(upgrade);
            //Act
            bool result = paymentObject.GeneratePayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactory_Should_Generate_FreeVideoSlip()
        {
            //Arrange
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = FactoryPayment.GetPaymentObject(video);
            //Act
            bool result = paymentObject.GeneratePayment();
            //Assert
            Assert.AreEqual(result, true);
        }

    }
}
