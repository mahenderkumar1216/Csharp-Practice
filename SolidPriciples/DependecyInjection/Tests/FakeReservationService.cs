using System.Collections.Generic;
using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Refactored;

namespace SolidPriciples.DependecyInjection.Tests
{
    internal class FakeReservationService:IReservationService
    {
        public bool WasCalled = false;
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            WasCalled = true;
        }
    }
}