class Program
{
    static void Main()
    {
        Console.WriteLine("");
        ICustomerService customerService = new CustomerService();
        customerService.ViewOrderHistory(1);
        customerService.PlaceOrder(1, 101);

        IAdminService adminService = new AdminService();
        adminService.AddProduct("Laptop", 1500.00m);
        adminService.RemoveProduct(101);

        IDeliveryService deliveryService = new DeliveryService();
        deliveryService.UpdateDeliveryStatus(1, "Delivered");

        IOrderProcessor orderProcessor = new CustomerService();
        orderProcessor.ProcessOrder(1);

        orderProcessor = new DeliveryService();
        orderProcessor.ProcessOrder(2);
        Console.WriteLine("");
    }
}