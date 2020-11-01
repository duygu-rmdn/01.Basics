using System;

namespace Schoolaship
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double avSucsused = double.Parse(Console.ReadLine());
            double minworkedMoney = double.Parse(Console.ReadLine());
            double scholaship = 0;
            if (avSucsused >= 5.50)
            {
                scholaship = avSucsused * 0.25;
                if (input < minworkedMoney)
                {
                    if (avSucsused * 0.25 > minworkedMoney * 0.35)
                    {
                        scholaship = avSucsused * 0.25;
                        Console.WriteLine($"You get a scholarship for excellent results {scholaship:f0} BGN");
                    }
                    else
                    {
                        scholaship = minworkedMoney * 0.35;
                        Console.WriteLine($"You get a Social scholarship {scholaship:f0} BGN");
                    }
                }
            }
            else if (input < minworkedMoney && avSucsused >= 4.50)
            {
                scholaship = minworkedMoney * 0.35;
                Console.WriteLine($"You get a Social scholarship {scholaship:f0} BGN");
            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
