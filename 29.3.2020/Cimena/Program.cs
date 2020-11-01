using System;

namespace Cimena
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = r * c * 12.00;
            }
            else if (type == "Normal")
            {
                income = r * c * 7.50;
            }
            else
            {
                income = r * c * 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
