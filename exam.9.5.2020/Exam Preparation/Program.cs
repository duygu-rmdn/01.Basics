using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int ex = int.Parse(Console.ReadLine());
            int enedgy = int.Parse(Console.ReadLine());
            int questions = 0;
            int counter = 0;
            while (enedgy > 0 && students >=10)
            {
                enedgy += ex * 2;
                students -= ex;
                questions = students * 2;
                enedgy -= questions* 3;
                students += students * 1 / 10;
                counter++;
            }
            if (enedgy <= 0)
            {
                Console.WriteLine("The trainer is too tired!");
                Console.WriteLine($"Questions answered: {questions}");
            }
            else if (students < 10)
            {
                Console.WriteLine("The students are too few!");
                Console.WriteLine($"Problems solved: {ex * counter}");
            }
        }
    }
}
