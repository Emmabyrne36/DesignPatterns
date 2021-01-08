using System.Linq;
using DesignPatterns.Behavioural.ChainOfResponsibility.Models;
using DesignPatterns.Behavioural.ChainOfResponsibility.PaymentProcessors;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class PayPalHandler : IReceiver<Order>
    {
        private PaypalPaymentProcessor PaypalPaymentProcessor { get; }
            = new PaypalPaymentProcessor();

        public void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            {
                PaypalPaymentProcessor.Finalize(order);
            }
        }
    }
}
