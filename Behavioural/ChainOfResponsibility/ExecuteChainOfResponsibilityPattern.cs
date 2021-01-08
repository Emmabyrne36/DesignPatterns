using System;
using DesignPatterns.Behavioural.ChainOfResponsibility.Handlers;
using DesignPatterns.Behavioural.ChainOfResponsibility.Handlers.PaymentHandlers;
using DesignPatterns.Behavioural.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    public static class ExecuteChainOfResponsibilityPattern
    {
        public static void Execute()
        {
            var order = new Order();
            order.LineItems.Add(new Item("ATOMOSV", "Atomos Ninja V", 499), 2);
            order.LineItems.Add(new Item("EOSR", "Canon EOS R", 1799), 1);

            order.SelectedPayments.Add(new Payment
            {
                PaymentProvider = PaymentProvider.Paypal,
                Amount = 1000
            });

            order.SelectedPayments.Add(new Payment
            {
                PaymentProvider = PaymentProvider.Invoice,
                Amount = 1797
            });

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus);


            var handler = new PaymentHandler(
                new PayPalHandler(),
                new InvoiceHandler(),
                new CreditCardHandler()
            );

            handler.Handle(order);

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus);
        }
    }
}
