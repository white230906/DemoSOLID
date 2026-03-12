namespace Dependency_Inversion;

public class ConsolePrinter
{
    public void Print(ShoppingCart cart)
    {
        Console.WriteLine();
        Console.WriteLine("ShoppingCart");
        Console.WriteLine("~~~~~~~~~~~~~");

        foreach (var items in cart.Items)
        {
            Console.WriteLine($"{items.Title} - {items.Price: C} x {items.Quantity} = {items.Quantity * items.Price}");
        }
    }
}