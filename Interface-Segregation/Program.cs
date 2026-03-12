
namespace Interface_Segregation;

class Program
{
    static void Main(string[] args)
    {
        IOnlineStore onlineStore = new OnlineStore();

        onlineStore.AddProduct(1, 1);
        onlineStore.AddProduct(2, 10);
        onlineStore.AddProduct(3, 100);
        
        onlineStore.SetCheckoutInfor(new CheckoutInfo());
        var order = onlineStore.Checkout();
        Console.WriteLine($"Order created, Id = {order.Id}");
    }
}