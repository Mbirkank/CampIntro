using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. sepete eklendi!" + urun.Name);
        }

        public void Ekle2(string productName, string Explanation, double Price, int stokAdedi )
        {
            Console.WriteLine("tebrikler. sepete eklendi : " +  productName);
        }
    }
}
