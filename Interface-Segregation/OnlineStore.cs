using System.Runtime.InteropServices;

namespace Interface_Segregation;

public class OnlineStore: IOnlineStore
{
    private readonly Dictionary<int, int> cart = new Dictionary<int, int>();
    private CheckoutInfo? checkoutInfo = null;
    
    public void AddProduct(int productId, int quantity)
    {
        if (!cart.ContainsKey(productId))
        {
            cart[productId] = cart[productId] + quantity;
        }
        else
        {
            cart.Add(productId, quantity);
        }
    }

    public Order Checkout()
    {
        if (checkoutInfo == null)
        {
            throw new InvalidComObjectException("checkoutInfo is null");
        }

        if (cart.Count == 0)
        {
            throw new InvalidComObjectException("cart is empty");
        }
        return new Order() {Id = 999 };
    }

    public void RemoveProduct(int productId, int quantity)
    {
        if (cart.TryGetValue(productId, out int value))
        {
            int newQuantity = quantity - value;
            if (newQuantity > 0)
            {
                cart[productId] = newQuantity;
            }
            else
            {
                cart.Remove(productId);
            }
        }
    }

    public void SetCheckoutInfor(CheckoutInfo checkoutInfo)
    {
        this.checkoutInfo = checkoutInfo;
    }
}