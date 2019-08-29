using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.Model
{
    public abstract class OrderSRP
    {
        protected readonly Cart _cart;

        protected OrderSRP(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {

        }
    }

    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }

    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }

    internal interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }

    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class ReservationService : IReservationService
    {
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            throw new NotImplementedException();
        }
    }

    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            throw new NotImplementedException();
        }
    }

    public class OnlineOrder:OrderSRP
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDeatils;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;
        public OnlineOrder(Cart cart, PaymentDetails paymentDetails):base(cart)
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
        public PosCreditOrder(Cart cart, PaymentDetails paymentDetails):base(cart)
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
        public PoSCashOrder(Cart cart)
            : base(cart)
        {
        }
    }
}