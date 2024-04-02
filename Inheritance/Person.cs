using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() 
        { 
        }

        public Person(string name, string address) 
        { 
            Name = name;
            Address = address;
        }        

        public string Show()
        {
            return Name + ", " + Address +  ".";
        }
    }
}
