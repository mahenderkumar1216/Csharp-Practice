using SolidPriciples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.DependecyInjection.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}