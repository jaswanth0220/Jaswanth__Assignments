using HandsOnApiUsingEntityFrameWork.DTOS;
using HandsOnApiUsingEntityFrameWork.Entities;
using HandsOnApiUsingEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEntityFrameWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        //public OrderController()
        //{
        //    orderRepository = new OrderRepository();
        //}

        [HttpGet,Route("GettAll")]
        public IActionResult GetAllOrders(int userId)
        {
            var orders = orderRepository.GetAllOrders(userId);
            return StatusCode(200, orders);
        }

        [HttpGet, Route("GetOrder/{id}")]
        public IActionResult GetOrder(Guid id)
        {
            var order = orderRepository.GetOrder(id);
            return StatusCode(200, order);
        }

        //[HttpPost,Route("MakeOrder")]
        //public IActionResult MakeOrder(Order order)
        //{
        //    orderRepository.MakeOrder(order);
        //    return StatusCode(200, order);
        //}
        [HttpPost, Route("MakeOrder")]
        public IActionResult MakeOrder([FromBody]OrderDTO orderDto)
        {
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                ProductId = orderDto.ProductId,
                UserId=orderDto.UserId

            };
            orderRepository.MakeOrder(order);
            return Ok(order);
        }
    }
}
