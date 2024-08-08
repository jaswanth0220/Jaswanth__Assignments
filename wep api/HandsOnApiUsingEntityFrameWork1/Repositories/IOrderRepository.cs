using HandsOnApiUsingEntityFrameWork.Entities;

namespace HandsOnApiUsingEntityFrameWork.Repositories
{
    public interface IOrderRepository
    {
        void MakeOrder(Order order); //Adding
        Order GetOrder(Guid orderId);
        List<Order> GetAllOrders(int userId);
    }
}
