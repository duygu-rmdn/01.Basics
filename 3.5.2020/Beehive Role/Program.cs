using System;

namespace Beehive_Role
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (intellect >= 80)
            {
                if (strength >= 80)
                {
                    if (gender == "female")
                    {
                        Console.WriteLine("Queen Bee");
                    }
                }
                else
                {
                    Console.WriteLine("Repairing Bee");
                }
            }
            else if (intellect < 80)
            {
                if (intellect >= 60)
                {
                    Console.WriteLine("Cleaning Bee");
                }
                if (strength >= 80)
                {
                    if (gender == "male")
                    {
                        Console.WriteLine("Drone Bee");
                    }
                }
                else if (strength >= 60)
                {
                    Console.WriteLine("Guard Bee");
                }
                else
                {
                    Console.WriteLine("Worker Bee");
                }
            }
        }
    }
}
