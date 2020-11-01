using System;

namespace Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            bool ischeating = false;
            while (name != "Midnight")
            {
                int points = 0;
                for (int i = 0; i < 6; i++)
                {
                    points = int.Parse(Console.ReadLine());
                    if (points < 0)
                    {
                        ischeating = true;
                        break;
                    }
                        sum += points;
                }
                if (ischeating)
                {
                    Console.WriteLine($"{name} was cheating!");
                    ischeating = false;
                }
                else if(!ischeating)
                {
                    sum = Math.Floor(sum / 600 * 100);
                    sum = sum * 0.06;
                    if (sum < 3.00)
                    {
                        sum = 2.00;
                    }
                    if (sum < 5.00)
                    {
                        Console.WriteLine($"{name} - {sum:f2}");
                    }
                    else
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("|   CERTIFICATE   |");
                        Console.WriteLine($"|    {sum:f2}/6.00    |");
                        Console.WriteLine("===================");
                        Console.WriteLine($"Issued to {name}");
                    }
                }
                points = 0;
                sum = 0;
                name = Console.ReadLine();
            }
        }
    }
}
