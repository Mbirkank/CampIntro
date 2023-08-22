using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "WashingMachine";
            product1.productPrice = 10000;

            Product product2 = new Product();
            product2.productName = "television";
            product2.productPrice = 5000;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.productName + " : " + product.productPrice);
            }

            Console.WriteLine("foreach bitti!!!");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName+ ":" + products[i].productPrice);
            }

            Console.WriteLine("for bitti!!!");

            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].productName + " : " + products[a].productPrice);
                a++;
            }

        }
    }

    class Product
    {
        public string productName { get; set; }

        public int productPrice { get; set; }
    }
}
