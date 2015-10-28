using DIP.LooseCoupling.Interfaces;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Fakes
{
    class FakeNotificationService : INotificationService
    {
        public bool WasCalled = false;
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            WasCalled = true;
        }
    }
}