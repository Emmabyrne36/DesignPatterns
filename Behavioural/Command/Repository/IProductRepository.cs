using DesignPatterns.Behavioural.Command.Models;

namespace DesignPatterns.Behavioural.Command.Repository
{
    // A pretend repository
    public interface IProductRepository
    {
        void DecreaseStockBy(string id, int amount);
        void IncreaseStockBy(string id, int amount);
        int GetStockFor(string id);
        Product FindBy(string id);
    }
}
