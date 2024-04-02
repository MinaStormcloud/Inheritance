using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        public int Salary { get; set; }
        public Teacher() 
        { 
        }

        public Teacher(string name, string address, int salary)
        {
            Name = name;
            Address = address;
            Salary = salary;
        }

        public string Show()
        {
            return Name + ", " + Address + ", " + Salary + " euro/month" + ".";
        }
    }
}
