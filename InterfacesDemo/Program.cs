using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work(); 
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),

            };
            foreach (var works in workers)
            {
                works.Work();
            }

        }
    }
    interface IWorker
    {
        void Work();  
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Yöneticiler için yemek zamanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yöneticiler için maaş alma zamanı");
        }

        public void Work()
        {
            Console.WriteLine("Yöneticiler için çalışma zamanı");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışanlar için yemek zamanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışanlar için maaş alma zamanı"); 
        }

        public void Work()
        {
            Console.WriteLine("Çalışanlar için çalışma zamanı");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robotlar için çalışma zamanı");
        }
    }
}
