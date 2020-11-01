using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square")
            {
                double site = double.Parse(Console.ReadLine());
                area = site * site;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "rectangle")
            {
                double siteA = double.Parse(Console.ReadLine());
                double siteB = double.Parse(Console.ReadLine());
                area = siteA * siteB;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (shape == "triangle")
            {
                double site = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = site * h / 2;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
