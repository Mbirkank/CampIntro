using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            
            sehirler.Add("ANKARA");
            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("ANKARA");
            
        }
    }
    class MyList <T> //Generic Class
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item) { }
        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
