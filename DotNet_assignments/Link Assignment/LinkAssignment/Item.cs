using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkAssignment
{
    public class Item
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        static void Main()
        {
            var items = new List<Item> 
            var ordersWithItems = orders.Join(items, o => o.ItemName, i => i.ItemName, (o, i) => new
            {
                o.OrderId,
                o.ItemName,
                o.OrderDate,
                TotalPrice = i.Price * o.Quantity
            });

            var groupedOrdersWithItems = ordersWithItems
                .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .OrderByDescending(g => g.Key.Year)
                .ThenByDescending(g => g.Key.Month)
                .Select(g => new
                {
                    Month = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Orders = g.ToList()
                });

            foreach (var group in groupedOrdersWithItems)
            {
                Console.WriteLine($"{group.Month:MMMM yyyy}");
                foreach (var order in group.Orders)
                {
                    Console.WriteLine($"{order.OrderId} {order.ItemName} {order.TotalPrice}");
                }
            }


            // using anonymous types
            var groupedOrdersWithItemsAnonymous = orders
    .Join(items, o => o.ItemName, i => i.ItemName, (o, i) => new
    {
        o.OrderId,
        o.ItemName,
        o.OrderDate,
        TotalPrice = i.Price * o.Quantity
    })
    .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
    .OrderByDescending(g => g.Key.Year)
    .ThenByDescending(g => g.Key.Month)
    .Select(g => new
    {
        Month = new DateTime(g.Key.Year, g.Key.Month, 1),
        Orders = g.ToList()
    });

            foreach (var group in groupedOrdersWithItemsAnonymous)
            {
                Console.WriteLine($"{group.Month:MMMM yyyy}");
                foreach (var order in group.Orders)
                {
                    Console.WriteLine($"{order.OrderId} {order.ItemName} {order.TotalPrice}");
                }
            }



        }
    }

   
}
