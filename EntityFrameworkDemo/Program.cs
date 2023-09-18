namespace EntityFrameworkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            GetProductsByCategoryId(1);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext northwindcontext = new NorthwindContext();
            var result = northwindcontext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var products in result)
            {
                Console.WriteLine(products.ProductName);
            }
        }
    }
}