using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4)); 

            var tip = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            Console.WriteLine(dortIslem.Topla(4,5));
            Console.WriteLine(dortIslem.Topla2());
            Console.ReadLine();
            
        }
    }
    public class DortIslem
    {
        int _s1;
        int _s2;
        public DortIslem(int s1, int s2)
        {
            _s1 = s1;
            _s2 = s2;
        }
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }
        public int Topla2()
        {
            return _s1 + _s2;
        }
        public int Carp2()
        {
            return _s1 * _s2;
        }
    }
}
