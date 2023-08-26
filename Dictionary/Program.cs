using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary sınıfı içinde sizin belirleyeceğiniz bir key'e uygun olarak deger saklar, zorunlulugu var.
              Key türünü belirlememiz şart (int, string vb...) */

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //veri ekliyelim
            AdYas.Add ("Birkan", 23);
            AdYas.Add("Zeynep", 20);
            AdYas.Add("Zeynep", 22);

         foreach (var kisiler in AdYas)
         {
                Console.WriteLine(kisiler);
         }

        }
    }
}
