namespace Interface_Segregation;

public interface IOnlineStore
{
    void AddProduct(int productId, int quantity);
    void RemoveProduct(int productId, int quantity);
    void SetCheckoutInfor(CheckoutInfo checkoutInfo);
    Order Checkout();
}