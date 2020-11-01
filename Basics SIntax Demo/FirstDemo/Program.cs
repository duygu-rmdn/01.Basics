using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());

            if (grades >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
