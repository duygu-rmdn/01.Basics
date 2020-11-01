using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double inches = double.Parse(input);
            double Centimeters = inches * 2.54;
            Console.WriteLine(Centimeters);
        }
    }
}
