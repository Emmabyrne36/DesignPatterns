using System;
using System.Collections.Generic;
using DesignPatterns.Behavioural.ChainOfResponsibility.Exceptions;
using DesignPatterns.Behavioural.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.Handlers
{
    public class PaymentHandler
    {
        private readonly IList<IReceiver<Order>> _receivers;

        public PaymentHandler(params IReceiver<Order>[] receivers)
        {
            _receivers = receivers;
        }

        public void Handle(Order order)
        {
            foreach (var r in _receivers)
            {
                Console.WriteLine($"Running: {_receivers.GetType().Name}");
                if (order.AmountDue > 0)
                    r.Handle(order);
                else
                    break;
            }

            if (order.AmountDue > 0)
                throw new InsufficientPaymentException();
            else
                order.ShippingStatus = ShippingStatus.ReadyForShipment;
        }

        public void SetNext(IReceiver<Order> next)
        {
            _receivers.Add(next);
        }
    }
}
