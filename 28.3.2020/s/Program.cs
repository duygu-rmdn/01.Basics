using System;

namespace s
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double aveMark = double.Parse(Console.ReadLine());
            double minSalery = double.Parse(Console.ReadLine());

            double socialScholarship =minSalery * 0.35;
            double excellenceScholarship = aveMark * 25;

            
            if (income < minSalery)
            {
                if (aveMark > 4.50)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else if (aveMark >= 5.50)
                    if (excellenceScholarship > socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN");
                    }
                    else if (socialScholarship > excellenceScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
            }
            else if (income > minSalery)
                if (aveMark >= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
        }
    }
}
