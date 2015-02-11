using System;
using System.Collections.Generic;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}