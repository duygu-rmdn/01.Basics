using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salery = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Facebook":
                        salery -= 150;
                        break;
                    case "Instagram":
                        salery -= 100;
                        break;
                    case "Reddit":
                        salery -= 50;
                        break;
                }

            }
            if (salery > 0)
            {
                Console.WriteLine(salery);
            }
            else if (salery <= 0)
            {
                Console.WriteLine("You have lost your salary.");

            }
        }
    }
}
