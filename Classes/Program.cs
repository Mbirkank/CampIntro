using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Birkan";
            customer1.Surname = "Karaer";
            customer1.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Engin",
                Surname = "Demiroğ",
                City = "Ankara"
            };

            string[] customers = new string[] {customer1.Name,customer2.Name,customer1.Surname,customer2.Surname};
            foreach (var oku in customers)
            {
                Console.WriteLine(oku);
            }


        }
    }
    
}
