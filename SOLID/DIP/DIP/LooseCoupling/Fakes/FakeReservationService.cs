using System.Collections.Generic;
using DIP.LooseCoupling.Interfaces;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Fakes
{
    class FakeReservationService : IReservationService
    {
        public bool WasCalled = false;
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            WasCalled = true;
        }
    }
}