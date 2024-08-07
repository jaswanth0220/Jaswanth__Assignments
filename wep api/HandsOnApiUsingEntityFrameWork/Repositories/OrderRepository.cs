using HandsOnApiUsingEntityFrameWork.Entities;

namespace HandsOnApiUsingEntityFrameWork.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ECommContext _context;

        public OrderRepository()
        {
            _context = new ECommContext();
        }

        public List<Order> GetAllOrders(int userId)
        {
            var orders = _context.Orders.Where(o => o.UserId == userId).ToList();
            return orders;
        }

        public Order GetOrder(Guid orderId)
        {
            var order = _context.Orders.SingleOrDefault(o => o.OrderId == orderId);
            return order;
        }

        public void MakeOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
