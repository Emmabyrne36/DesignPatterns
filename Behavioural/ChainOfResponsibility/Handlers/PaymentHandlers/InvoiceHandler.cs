using System.Linq;
using DesignPatterns.Behavioural.ChainOfResponsibility.Models;
using DesignPatterns.Behavioural.ChainOfResponsibility.PaymentProcessors;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class InvoiceHandler : IReceiver<Order>
    {
        public InvoicePaymentProcessor InvoicePaymentProcessor { get; }
            = new InvoicePaymentProcessor();

        public void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Invoice))
            {
                InvoicePaymentProcessor.Finalize(order);
            }
        }
    }
}
