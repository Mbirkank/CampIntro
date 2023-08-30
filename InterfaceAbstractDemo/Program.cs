using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000,10,18), FirstName = "Mustafa Birkan", LastName = "KARAER", NationalityId = "16918855632" });
            Console.ReadLine();
        }
    }
}
