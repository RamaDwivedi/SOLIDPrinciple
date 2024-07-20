public class CreditCardPayment : IPaymentGateway
{
    public void ProcessPayment(string cardNumber, decimal amount)
    {
        // Logic to process credit card payment
        Console.WriteLine($"Processing credit card payment of {amount:C} using card {cardNumber}.");
    }

   
}

public class PayPalPayment : IPaymentGateway
{
    public void ProcessPayment(string email, decimal amount)
    {
        // Logic to process PayPal payment
        Console.WriteLine($"Processing PayPal payment of {amount:C} using email {email}.");
    }

   
}