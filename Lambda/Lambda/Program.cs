using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("123456789", "Shashank", "158 Vasudha Apartment", 12));
            list.Add(new Person("269578413", "Suyog", " 911 Freak Street", 55));
            list.Add(new Person("365219875", "Shubham", "22 Washington state", 77));
            list.Add(new Person("214537912", "Ankit", "23 San Diego", 47));
            list.Add(new Person("854136924", "Bhavesh", "619 Philladelphia lane", 14));
            list.Add(new Person("745896147", "Suraj", "715 Ohio route 66", 85));
            list.Add(new Person("789683214", "Omkar", "123 Miami beach", 59));

        }
    }
}