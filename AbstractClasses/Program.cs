using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            aMevzuat aMevzuat = new aMevzuat();
            {
                aMevzuat.Kaydet();
                aMevzuat.Degerlendir();
            }
        }
    }
    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("kaydedildi.");
        }
    }
    class aMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }
    class bMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına göre değerlendirildi.");
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("eklendi");
        }
        public void Delete()
        {
            Console.WriteLine("silindi");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
