public class CustomerService : ICustomerService, IOrderProcessor
{
    public void ViewOrderHistory(int customerId)
    {
        // Logic to view order history
        Console.WriteLine($"Viewing order history for customer {customerId}.");
    }

    public void PlaceOrder(int customerId, int productId)
    {
        // Logic to place an order
        Console.WriteLine($"Placing order for customer {customerId} and product {productId}.");
    }

    public void ProcessOrder(int orderId)
    {
        // Logic to process an order
        Console.WriteLine($"Processing order {orderId}.");
    }
}

public class AdminService : IAdminService
{
    public void AddProduct(string productName, decimal price)
    {
        // Logic to add a product
        Console.WriteLine($"Adding product {productName} with price {price}.");
    }

    public void RemoveProduct(int productId)
    {
        // Logic to remove a product
        Console.WriteLine($"Removing product {productId}.");
    }
}

public class DeliveryService : IDeliveryService, IOrderProcessor
{
    public void UpdateDeliveryStatus(int orderId, string status)
    {
        // Logic to update delivery status
        Console.WriteLine($"Updating delivery status for order {orderId} to {status}.");
    }

    public void ProcessOrder(int orderId)
    {
        // Logic to process an order
        Console.WriteLine($"Processing order {orderId}.");
    }
}