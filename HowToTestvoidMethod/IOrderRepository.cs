namespace HowToTestvoidMethod
{
    public interface IOrderRepository
    {
        void UpdateOrderStatus(int orderId, string status);
    }
}