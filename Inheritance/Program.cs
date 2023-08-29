using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Birkan" }, new Student{FirstName = "Zeynep" }, new Person{FirstName = "Emre" }
            };
            foreach (var adlar in persons)
            {
                Console.WriteLine(adlar.FirstName);
            }
            
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class  Student : Person
    {
        public string Number { get; set; }
    }
}
