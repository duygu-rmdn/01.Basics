using System;

namespace Exam_Retention
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());

            for (int i = 1; i <= seasons; i++)
            {
                students = Math.Ceiling(students * 90 / 100);
                students = Math.Ceiling(students * 90 / 100);
                students = Math.Ceiling(students * 80 / 100);
                
                if (i  % 3 == 0)
                {
                    students += Math.Ceiling(students * 15 / 100);
                }
                else
                {
                    students += Math.Ceiling(students * 5 / 100);
                }
            }
            Console.WriteLine($"Students: {students} ");




        }
    }
}
