using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedCounter = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            bool isFailed = true;
            double gradesSum = 0;
            int solveproblemCount = 0;
            string lasnName = "";
            while (failedTimes<failedCounter)
            {
                string problemname = Console.ReadLine();
                if (problemname == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <=4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solveproblemCount++;
                lasnName = problemname;
            }
            if (!isFailed)
            {
                Console.WriteLine($"Average score: {gradesSum / solveproblemCount:F2}");
                Console.WriteLine($"Number of problems: {solveproblemCount}");
                Console.WriteLine($"Last problem: {lasnName}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failedCounter} poor grades.");
            }


        }
    }
}
