namespace ISP.violation;

public interface IPaymentProcessor
{
    void ChargeCreditCard(decimal amount, string creditCardNumber, string expirationDate, string cvv);
    void ProcessPayPal(decimal amount, string payPalUsername, string payPalPassword);

}
