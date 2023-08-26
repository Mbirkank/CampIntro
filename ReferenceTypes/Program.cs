using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enom,boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //Console.WriteLine(sayi1);

            ////Arrays,Class,İnterface... reference types
            //int[] sayilar1 = new int[] {1, 2, 3};
            //int[] sayilar2 = new int[] {10, 20, 30};

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Birkan";

            person2 = person1;
            person1.FirstName = "Aboubakar";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = 1234567890;
            Person person3 = customer;
            Employee employee = new Employee();
            employee.FirstName = "Veli";
            
          
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);



        }
    }
    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
    //base class: Person
    class Customer : Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
