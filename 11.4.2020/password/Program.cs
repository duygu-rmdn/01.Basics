using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pasword = Console.ReadLine();
            string cp = Console.ReadLine();
            while (cp != pasword)
            {
                cp = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}!");


        }
    }
}
