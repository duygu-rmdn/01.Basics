using System;

namespace metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string unitInput = Console.ReadLine();
            string unitOutput = Console.ReadLine();
            double result = 0;
            if (unitInput  == "mm")
            {
                if (unitOutput == "m")
                {
                    result = value / 1000;
                }

                else if (unitOutput == "cm")
                {
                    result = value / 10;
                }
                else if (unitOutput == "mm")
                {
                    result = value;
                }
                }
                else if (unitInput == "cm")
                {
                if (unitOutput == "m")
                {
                    result = value / 100;
                }
                else if (unitOutput == "cm")
                {
                    result = value;
                }
                else if (unitOutput == "mm")
                {
                    result = value * 10;
                }
                    }
                    else if (unitInput == "m")

                    {
                if (unitOutput == "m")
                {
                    result = value;
                }
                else if (unitOutput == "cm")
                {
                    result = value * 100;
                }
                else if (unitOutput == "mm")
                {
                    result = value * 1000;
                }
                        }
                        Console.WriteLine($"{result:f3}");
          }
    }
}
