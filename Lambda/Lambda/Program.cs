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

            //UC2
            Console.WriteLine("retrieve data");
            foreach (Person person in list.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + ".....Age: " + person.Age);
            }

            //UC3
            Console.WriteLine("Checking teenager or not.");
            foreach (Person person in list.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name: " + person.Name + ".....Age: " + person.Age);
            }

            //UC4
            Console.WriteLine("Getting average of all the person age.");
            double avrage = list.Average(e => e.Age);
            Console.WriteLine("The avearge of all the person age is :" + avrage);

            //UC5
            Console.WriteLine("Checking wether a person having same name 'Shashank' exist or not.");
            if (list.Exists(e => e.Name == "Shashank"))
            {
                Console.WriteLine("Yess, Person having same name exist.");
            }

            //UC6
            Console.WriteLine("Skipping every person whose age is less than 60 year");
            foreach (Person person1 in list.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name :" + person1.Name + "Age:" + person1.Age);
            }
        }
    }
}