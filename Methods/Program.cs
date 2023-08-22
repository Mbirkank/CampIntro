using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tekrar tekrar kodları kullanabilmemizi sağlıyor.

            string productName = "Apple";
            double productPrice = 100;
            string productExplanation = "amasya apple";


            string[] furuits = new string[] { };
            

            Product product1 = new Product();
            product1.Name = "apple"; 
            product1.Price = 100;
            product1.Explanation = "amasya apple";

            Product product2 = new Product();
            product2.Name = "watermelon";
            product2.Price = 200;
            product2.Explanation = "diyarbakir's watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Explanation);
                Console.WriteLine("--------");
                
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            Console.WriteLine("--------");

            sepetManager.Ekle2("armut", "yeşil armut", 16, 10);
            sepetManager.Ekle2("elma", "kırmızı elma", 18, 1);
        }
    }
}
