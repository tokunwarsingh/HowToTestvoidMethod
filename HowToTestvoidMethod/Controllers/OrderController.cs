using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HowToTestvoidMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;
        private readonly ILogger<OrderController> logger;

        public OrderController(IOrderRepository orderRepository, ILogger<OrderController> logger)
        {
            this.orderRepository = orderRepository;
            this.logger = logger;
        }

        [HttpPut(Name = "GetWeatherForecast")]
        public void UpdateOrder()
        {
            this.orderRepository.UpdateOrderStatus(1, "Added");
            this.logger.LogWarning("messgae");
        }
    }
}
