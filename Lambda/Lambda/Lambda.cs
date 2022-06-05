using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Person
    {
        public string SSN;
        public string name;
        public string address;
        public int age;
        public Person(string ssn, string name, string address, int age)
        {
            this.SSN = ssn;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
