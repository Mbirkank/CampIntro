namespace LinqProject
{
    internal class Test
    {
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 5).ToList();
        }
    }
}