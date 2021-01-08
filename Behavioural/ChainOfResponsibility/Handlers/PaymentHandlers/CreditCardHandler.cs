using System.Linq;
using DesignPatterns.Behavioural.ChainOfResponsibility.Models;
using DesignPatterns.Behavioural.ChainOfResponsibility.PaymentProcessors;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class CreditCardHandler : IReceiver<Order>
    {
        public CreditCardPaymentProcessor CreditCardPaymentProcessor { get; }
            = new CreditCardPaymentProcessor();

        public void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.CreditCard))
                CreditCardPaymentProcessor.Finalize(order);
        }
    }
}
