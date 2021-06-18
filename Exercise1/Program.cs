using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Person person = new Person();
            person.Name = "Amar";
            person.Age = 40;
            Console.WriteLine("Simple Properties Demo \n");
            Console.WriteLine("Person details - Name = " + person.Name + ",Age = " + person.Age);
            Console.WriteLine("Person details (After incrementing age) - Name = " + person.Name + ",Age = " + (person.Age + 1));
                    
        }
    }
}