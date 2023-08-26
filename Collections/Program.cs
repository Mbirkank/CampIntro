using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Birkan", "Emre", "Zeynep"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[4];
            //isimler[3] = "Aboubakar";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Birkan", "Emre", "Zeynep" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Aboubakar");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
