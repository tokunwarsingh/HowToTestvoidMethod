using HowToTestvoidMethod;
using HowToTestvoidMethod.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Tests
{
    public class OrderControllerTest
    {
        private  Mock<IOrderRepository> orderRepositoryMock;
        private  Mock<ILogger<OrderController>> loggerMock;

        [Fact]
        public void UpdateOrderTest()
        {
            // Arrange
            orderRepositoryMock = new Mock<IOrderRepository>();
            loggerMock = new Mock<ILogger<OrderController>>();

            var orderController = new OrderController(orderRepositoryMock.Object, loggerMock.Object);

            //Act & Assert
            orderController.UpdateOrder();
            orderRepositoryMock.Verify(x=>x.UpdateOrderStatus(1, "Added"), Times.Once());
            loggerMock.Verify(x=>x.LogWarning("messgae"), Times.Once());
        }

    }
}
