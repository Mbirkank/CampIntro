using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDegeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            
            AdYas.Add("Birkan", 23);
            AdYas.Add("Zeynep", 20);
            AdYas.Add("Birisi", 22);

            foreach (var kisiler in AdYas)
            {
                Console.WriteLine(kisiler);
            }
            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("eleman sayısı"+  eleman);

            AdYas.Remove("Birisi");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();


        }
    }
}
