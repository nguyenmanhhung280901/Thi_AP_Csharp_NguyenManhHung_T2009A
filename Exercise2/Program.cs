using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str;
            string words;
            int count = 0;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            words = Console.ReadLine();
            string[] c = str.Split();
            for (int i = 0; i < c.Length; i++)
            {
                if (words != null && words.Equals(c[i]))
                {
                    count++;
                }
                
            }

            if (count <= 1 )
            {
                Console.WriteLine($"Word found {count} time in the string");
            }
            else
            {
                Console.WriteLine($"Word found {count} times in the string");
            }
        }
    }
}