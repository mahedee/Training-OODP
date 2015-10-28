using System;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}