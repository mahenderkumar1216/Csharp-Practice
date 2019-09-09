using SolidPriciples.Model;
using SolidPriciples.Refactored;
using System.Collections.Generic;


namespace SolidPriciples.DependecyInjection.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
