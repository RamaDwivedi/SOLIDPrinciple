public interface IOrderProcessor
{
    void ProcessOrder(int orderId);
}

public interface ICustomerService
{
    void ViewOrderHistory(int customerId);
    void PlaceOrder(int customerId, int productId);
}

public interface IAdminService
{
    void AddProduct(string productName, decimal price);
    void RemoveProduct(int productId);
}

public interface IDeliveryService
{
    void UpdateDeliveryStatus(int orderId, string status);
}