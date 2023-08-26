using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //projede ürün ile ilgili operasyonlar bu dosyada (productmanager) bulunur
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + ":  EKLENDİ");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + ":  GÜNCELLENDİ");
        }
    }
}
