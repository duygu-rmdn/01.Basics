using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorMArksLimite = int.Parse(Console.ReadLine());
            bool isEnought = false;
            int poorMArkCound = 0;
            double totalMarks = 0;
            int taskSolve = 0;
            string taskname = "";
            while (!isEnought)
            {
                 string input = Console.ReadLine();
                if (input == "Enought")
                {
                    isEnought = true;
                    break;
                }
                taskname = input;
                int mark = int.Parse(Console.ReadLine());
                totalMarks += mark;
                if (mark <= 4)
                {
                    poorMArkCound++;
                    if(poorMArkCound>=poorMArksLimite)
                    {
                        
                        break;
                    }
                    
                }

            }
            if (isEnought)
            {
                double avs = 1.0* totalMarks / taskSolve;
                Console.WriteLine($"Average score: {avs}");
                Console.WriteLine($"Number of problems: {taskSolve}");
                    Console.WriteLine($"Last problem: {taskname}");
            }
            else
            {
                Console.WriteLine($"You need a break, {poorMArkCound} poor grades.");
               
            }
        }
    }
}
