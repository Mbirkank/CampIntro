namespace EntityFrameworkDemov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentACarContext context = new RentACarContext();
            foreach (var cars in context.Cars)
            {
                Console.WriteLine(cars.ModelName+""+cars.DailyPrice);
            }
        }
    }
}