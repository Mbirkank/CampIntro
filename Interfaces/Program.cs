using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Birkan",
            //    LastName = "Karaer",
            //    Adress = "Ankara"
            //};
            

            //Student student = new Student
            //{
            //    Id = 2,
            //    FirstName = "Zehra",
            //    LastName = "Güler",
            //    Departmant = "Mathematic"
            //};
            //manager.Add(student);
            //Console.ReadLine();
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleServerCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlCustomerDal(),
                
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
