using DesignPatterns.Behavioural.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.PaymentProcessors
{
    public interface IPaymentProcessor
    {
        void Finalize(Order order);
    }
}
