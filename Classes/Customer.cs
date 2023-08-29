using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //Field
        //public string FirstName;
        //Property
        public int Id { get; set; }
        private string kodname;
        public string Name { get { return "Mr." + kodname;  }
            set { kodname = value;} }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
