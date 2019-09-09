using SolidPriciples.Refactored;

namespace SolidPriciples.DependecyInjection.Tests
{
    internal class FakeNotificationService:DependecyInjection.Interfaces.INotificationService
    {
        public bool WasCalled = false;
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            WasCalled = true;
        }
    }
}