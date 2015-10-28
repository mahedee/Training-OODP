using DIP.LooseCoupling.Interfaces;
using DIP.LooseCoupling.Model;

namespace DIP.LooseCoupling.Fakes
{
    class FakePaymentProcessor : IPaymentProcessor
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