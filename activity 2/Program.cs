internal class Program
{
    private static void Main(string[] args)
    {
        List<decimal> prices = new List<decimal>();
        decimal price;

        Console.WriteLine("Enter item prices (type -1 to finish):");

        // Input prices until -1 is entered
        while (true)
        {
            price = Convert.ToDecimal(Console.ReadLine());
            if (price == -1) break;
            if (price >= 0)
                prices.Add(price);
            else
                Console.WriteLine("Invalid price. Please enter a positive number or -1 to finish.");
        }

        // Display summary
        Console.WriteLine("\nShopping Cart Summary:");
        Console.WriteLine($"Total Items: {prices.Count}");
        Console.WriteLine($"Average Price: {prices.Average():C}");
        Console.WriteLine($"Highest Price: {prices.Max():C}");
        Console.WriteLine($"Lowest Price: {prices.Min():C}");
    }
}