using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double  salary = double.Parse(Console.ReadLine());

            double socialS = 0;
            double grateS = 0;

            if (income < salary) 
            {
                if (grade > 4.50)
                {
                    socialS = salary * 0.35;
                }
            }

            if (grade >= 5.50)
            {
                grateS = grade * 25;
                Console.WriteLine($"You get a  scholarship for excellent results {Math.Floor(grateS)} BGN");
            }
            if (grateS == 0)
            {
                if (socialS == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialS)} BGN");
                }
            }
            else if (socialS == 0)
            {
                if (grateS == 0)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a  scholarship for excellent results {Math.Floor(grateS)} BGN");
                }
            }
            else
            {
                if ( socialS > grateS)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialS)} BGN");
                }
                else if (socialS <= grateS)
                {
                    Console.WriteLine($"You get a  scholarship for excellent results {Math.Floor(grateS)} BGN");
                }
            }
        }
    }
}
