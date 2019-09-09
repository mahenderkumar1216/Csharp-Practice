using SolidPriciples.Refactored;

namespace SolidPriciples.DependecyInjection.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}