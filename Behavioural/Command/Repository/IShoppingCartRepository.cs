using DesignPatterns.Behavioural.Command.Models;

namespace DesignPatterns.Behavioural.Command.Repository
{
    // A pretend repository
    public interface IShoppingCartRepository
    {
        void Add(Product product);
        Product Get(string id);
        void RemoveAll(string id);
        void DecreaseQuantity(string id);
        void IncreaseQuantity(string id);
    }
}
