public interface IPaymentGateway
{
    void ProcessPayment(string paymentInfo, decimal amount);
}