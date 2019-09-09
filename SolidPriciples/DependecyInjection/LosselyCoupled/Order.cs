using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Services;
using SolidPriciples.Refactored;
using System;

namespace SolidPriciples.Model.LosselyCoupled.Model
{
    public class Order
    {
        private readonly SolidPriciples.Refactored.Cart _cart;
        private readonly PaymentDetails _paymentDetails;
        private readonly INotificationService _notifyCustomer;
        public Order(SolidPriciples.Refactored.Cart cart, PaymentDetails paymentDetails, INotificationService notifyCustomer)
        {
            _cart = cart;
            _paymentDetails = paymentDetails;
            _notifyCustomer = notifyCustomer;
        }
            //Tightly Coupled
            public void Checkout(Refactored.Cart cart, PaymentDetails paymentDetails, bool notifyCustomer)
            {
                if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
                {
                    ChargeCard(paymentDetails, cart);
                }

                ReserveInventory(cart);

                if (notifyCustomer)
                {
                    _notifyCustomer.NotifyCustomerOrderCreated(cart);
                }
            }

            

            public void ReserveInventory(Refactored.Cart cart)
            {
                foreach (var item in cart.Items)
                {
                    try
                    {
                        var inventorySystem = new InventorySystem();
                        inventorySystem.Reserve(item.Sku, item.Quantity);

                    }
                    catch (InsufficientInventoryException ex)
                    {
                        throw new OrderException("Insufficient inventory for item " + item.Sku, ex);
                    }
                    catch (Exception ex)
                    {
                        throw new OrderException("Problem reserving inventory", ex);
                    }
                }
            }

            public void ChargeCard(PaymentDetails paymentDetails, Refactored.Cart cart)
            {
                using (var paymentGateway = new PaymentGateway())
                {
                    try
                    {
                        paymentGateway.Credentials = "account credentials";
                        paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                        paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                        paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                        paymentGateway.NameOnCard = paymentDetails.CardholderName;
                        paymentGateway.AmountToCharge = cart.TotalAmount();

                        paymentGateway.Charge();
                    }
                    catch (AvsMismatchException ex)
                    {
                        throw new OrderException("The card gateway rejected the card based on the address provided.", ex);
                    }
                    catch (Exception ex)
                    {
                        throw new OrderException("There was a problem with your card.", ex);
                    }
                }
            }
        }
        public class OrderException : Exception
        {
            public OrderException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }
}