using System;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}