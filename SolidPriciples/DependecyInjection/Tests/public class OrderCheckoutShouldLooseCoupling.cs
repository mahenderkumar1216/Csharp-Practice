using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPriciples.DependecyInjection.Services;
using SolidPriciples.Model;
using SolidPriciples.Refactored;


namespace SolidPriciples.DependecyInjection.Tests
{
    [TestClass]
    public class public_class_OrderCheckoutShouldLooseCoupling
    {
        Refactored.Cart _cart;
        [TestInitialize]
        public void SetUp()
        {
            _cart = new Refactored.Cart();
        }
        [TestMethod]
        public void SendTotalAmountToCreditCardProcessor()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new FakeNotificationService();
            _cart.Add(new OrderItem() { Quantity = 5, Sku = "B4GO_APPLE" });
            _cart.Add(new OrderItem() { Quantity = 6, Sku = "SPECIAL_CANDYBAR" });
            var paymentDetails = new PaymentDetails()
            { PaymentMethod = PaymentMethod.CreditCard };
            var order = new LosselyCoupled.OnlineOrder(_cart,
                                        paymentDetails,
                                        paymentProcessor,
                                        reservationService,
                                        notificationService);

            order.Checkout();

            Assert.IsTrue(paymentProcessor.WasCalled);
            Assert.AreEqual(_cart.TotalAmount(), paymentProcessor.AmountPassed);

        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new NotificationService();
            var cart = new Refactored.Cart() { CustomerEmail = "someone@nowhere.com" };
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };
            var order = new LosselyCoupled.OnlineOrder(cart,
                                        paymentDetails,
                                        paymentProcessor,
                                        reservationService,
                                        notificationService);

            order.Checkout();

            // if I got here, I guess it worked...
        }
    }
}