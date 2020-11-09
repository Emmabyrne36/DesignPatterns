using System;
using DesignPatterns.Behavioural.Strategy.Models;

namespace DesignPatterns.Behavioural.Strategy
{
    public static class ExecuteStrategyPattern
    {
        public static void Execute()
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

            Console.WriteLine(order.GetTax(new SwedenSalesTaxStrategy()));
        }
    }
}
