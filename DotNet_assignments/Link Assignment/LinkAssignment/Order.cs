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
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        static void Main()
        {
            var orders = new List<Order> {
                new Order { OrderId = 1, ItemName = "Laptop", OrderDate = new DateTime(2024, 7, 15), Quantity = 2 },
                new Order { OrderId = 2, ItemName = "Smartphone", OrderDate = new DateTime(2024, 7, 10), Quantity = 5 },
                new Order { OrderId = 3, ItemName = "Headphones", OrderDate = new DateTime(2024, 7, 20), Quantity = 1 },
                new Order { OrderId = 4, ItemName = "Monitor", OrderDate = new DateTime(2024, 6, 25), Quantity = 3 },
                new Order { OrderId = 5, ItemName = "Keyboard", OrderDate = new DateTime(2024, 7, 5), Quantity = 10 },
                new Order { OrderId = 6, ItemName = "Mouse", OrderDate = new DateTime(2024, 6, 30), Quantity = 7 }
            };
            var sortedOrders = orders
                .OrderByDescending(o => o.OrderDate)
                .ThenByDescending(o => o.Quantity);

            foreach (var order in sortedOrders)
            {
                Console.WriteLine($"{order.OrderId} {order.ItemName} {order.OrderDate} {order.Quantity}");
            }

            var groupedOrders = orders
        .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
        .OrderByDescending(g => g.Key.Year)
        .ThenByDescending(g => g.Key.Month)
        .Select(g => new
        {
            Month = new DateTime(g.Key.Year, g.Key.Month, 1),
            Orders = g.ToList()
        });


            var items = new List<Item> {  new Item { ItemName = "Laptop", Price = 1200.00m },
                new Item { ItemName = "Smartphone", Price = 800.00m },
                new Item { ItemName = "Headphones", Price = 150.00m },
                new Item { ItemName = "Monitor", Price = 300.00m },
                new Item { ItemName = "Keyboard", Price = 50.00m }, };


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

            foreach (var group in groupedOrders)
                {
                    Console.WriteLine($"{group.Month:MMMM yyyy}");
                    foreach (var order in group.Orders)
                    {
                        Console.WriteLine($"{order.OrderId} {order.ItemName} {order.OrderDate} {order.Quantity}");
                    }
                }


            var allQuantitiesPositive = orders.All(o => o.Quantity > 0);

            var itemWithLargestQuantity = orders
                .OrderByDescending(o => o.Quantity)
                .FirstOrDefault()?.ItemName;

            var ordersBeforeJanuary = orders.Any(o => o.OrderDate < new DateTime(DateTime.Now.Year, 1, 1));



            var numbers = new int[] {
    50, 150, 200, 300, 450, 600, 700, 900, 1100, 1300
};
            var evenCount = numbers.Count(n => n % 2 == 0);

            var itemQuantities = orders
                .GroupBy(o => o.ItemName)
                .Select(g => new
                {
                    ItemName = g.Key,
                    TotalQuantity = g.Sum(o => o.Quantity)
                });

            var itemWithMaxOrders = itemQuantities
                .OrderByDescending(i => i.TotalQuantity)
                .FirstOrDefault();

        }
    }

   

}
