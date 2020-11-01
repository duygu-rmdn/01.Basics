using System;

namespace Exam_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();
            double percents = 0.0;
            
            if (course == "Basics")
            {
                if (ex == 1)
                {
                    percents = 0.08;
                    
                }
                else if (ex == 2)
                {
                    percents = 0.09;
                }
                else if (ex == 3)
                {
                    percents = 0.09;
                }
                else if (ex == 4)
                {
                    percents = 0.10;
                }
            }
            else if (course == "Fundamentals")
            {
                if (ex == 1)
                {
                    percents = 0.11;
                }
                else if (ex == 2)
                {
                    percents = 0.11;
                }
                else if (ex == 3)
                {
                    percents = 0.12;
                }
                else if (ex == 4)
                {
                    percents = 0.13;
                }
            }
            else if (course == "Advanced")
            {
                if (ex == 1)
                {
                    percents = 0.14;
                    
                }
                else if (ex == 2)
                {
                    percents = 0.14;
                 
                }
                else if (ex == 3)
                {
                    percents = 0.15;
                  
                }
                else if (ex == 4)
                {
                    percents = 0.16;
                    
                }
            }
            double totalPoints = points * percents ;


            if (course == "Basics")
            {
                if (ex == 1)
                {
                    totalPoints *= 0.80;
                }
            }
            if (course == "Advanced")
            {
                totalPoints *= 1.20;
            }
            Console.WriteLine($"Total points: {totalPoints:f2}");
        }
    }
}
