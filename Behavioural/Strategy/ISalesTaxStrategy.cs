using DesignPatterns.Behavioural.Strategy.Models;

namespace DesignPatterns.Behavioural.Strategy
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
