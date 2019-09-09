using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Model;

namespace SolidPriciples.DependecyInjection.Tests
{
    internal class FakePaymentProcessor:IPaymentProcessor
    {
        public decimal AmountPassed = 0;
        public bool WasCalled = false;
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            WasCalled = true;
            AmountPassed = amount;
        }
    }
}