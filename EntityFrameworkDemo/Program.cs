namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}