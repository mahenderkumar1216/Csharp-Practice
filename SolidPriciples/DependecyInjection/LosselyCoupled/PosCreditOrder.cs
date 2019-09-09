using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Model;
using SolidPriciples.Refactored;
using SolidPriciples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.DependecyInjection.LosselyCoupled
{
    public class PosCreditOrder:OrderAbstract
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        public PosCreditOrder(Refactored.Cart cart, PaymentDetails paymentDetails) :base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount());
            base.Checkout();
        }
    }
}