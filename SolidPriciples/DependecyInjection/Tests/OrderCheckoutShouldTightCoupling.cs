using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPriciples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.DependecyInjection.Tests
{
    [TestClass]
    public class OrderCheckoutShouldTightCoupling
    {
        [TestMethod]
        public void NotFailWithNoItemsNoNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = false;

            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked...
        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart() { CustomerEmail = "someone@nowhere.com" };
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = true;

            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked...
        }
    }
}