using System;
using DesignPatterns.Behavioural.Command.Repository;

namespace DesignPatterns.Behavioural.Command
{
    public static class ExecuteCommandPattern
    {
        public static void Execute()
        {
            var shoppingCartRepo = new ShoppingCartRepository();
            var productsRepo = new ProductsRepository();

            var product = productsRepo.FindBy("1");

            var addToCartCommand = new AddToCartCommand(shoppingCartRepo, productsRepo, product);
            var increaseQuantityCommand = new ChangeQuantityCommand(
                ChangeQuantityCommand.Operation.Increase,
                shoppingCartRepo,
                productsRepo,
                product);

            var manager = new CommandManager();
            manager.Invoke(addToCartCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);

            PrintCart(shoppingCartRepo);

            manager.Undo();

            PrintCart(shoppingCartRepo);

            void PrintCart(ShoppingCartRepository repo)
            {
                if (repo == null) throw new ArgumentNullException(nameof(repo));

                var p = repo.Get(product.ArticleId);

                if (p == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your cart is empty");
                    return;
                }

                Console.WriteLine("In your cart is the following item: ");
                Console.WriteLine($"Product name: { p.Name }");
                Console.WriteLine($"Amount in stock: {p.AmountInStock}");
                Console.WriteLine($"Quantity in basket: {p.Quantity}");
            }
        }
    }
}
