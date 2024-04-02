using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public int Credits { get; set; }
        public Student() 
        { 
        }
        public Student(string name, string address) 
        {
            Name = name;
            Address = address; 
            Credits = 0;
        }

        public string Show() 
        {            
            return Name + ", " + Address + ", " + "Study Credits: " + Credits + ".";

        }
        
        public void Study() 
        {
            Credits++;            
        }
    }
}
