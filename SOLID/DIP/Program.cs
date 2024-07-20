public class CheckoutService
{
    private readonly IPaymentGateway _paymentGateway;

    public CheckoutService(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void Checkout(string paymentInfo, decimal amount)
    {
        _paymentGateway.ProcessPayment(paymentInfo, amount);
    }
}

class Program
{
    static void Main()
    {
Console.WriteLine("");
        IPaymentGateway creditCardPayment = new CreditCardPayment();
        CheckoutService checkoutService = new CheckoutService(creditCardPayment);
        checkoutService.Checkout("1234-5678-9876-5432", 99.99m);

        IPaymentGateway payPalPayment = new PayPalPayment();
        checkoutService = new CheckoutService(payPalPayment);
        checkoutService.Checkout("john.doe@example.com", 49.99m);
        Console.WriteLine("");
    }
}
