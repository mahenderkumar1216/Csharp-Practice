using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.Services
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}