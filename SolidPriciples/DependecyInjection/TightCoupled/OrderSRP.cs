using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.DependecyInjection.Services;
using SolidPriciples.Services;
using SolidPriciples.Refactored;
using System;
using System.Collections.Generic;


namespace SolidPriciples.Model
{
    public abstract class OrderSRP
    {
        protected readonly Refactored.Cart _cart;

        protected OrderSRP(Refactored.Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {

        }
    }   
    public class OnlineOrder:OrderSRP
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDeatils;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;
        public OnlineOrder(Refactored.Cart cart, PaymentDetails paymentDetails):base(cart)
        {
            _notificationService = new NotificationService();
            _paymentDeatils = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
            _reservationService = new ReservationService();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDeatils, _cart.TotalAmount());
            _reservationService.ReserveInventory(_cart.Items);
            _notificationService.NotifyCustomerOrderCreated(_cart);
            base.Checkout();
        }
    }

    public class PosCreditOrder:OrderSRP
    {

        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        public PosCreditOrder(Refactored.Cart cart, PaymentDetails paymentDetails):base(cart)
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
    public class PoSCashOrder : OrderSRP
    {
        public PoSCashOrder(Refactored.Cart cart)
            : base(cart)
        {
        }
    }
}