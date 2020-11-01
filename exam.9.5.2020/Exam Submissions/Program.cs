using System;

namespace Exam_Submissions
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int ex = int.Parse(Console.ReadLine());

            double submit = Math.Ceiling(ex * 2.8);
            submit *= students;
            int ez3 = ex / 3;
            submit += students * ez3;
            double KB = Math.Ceiling(submit / 10);
            KB *= 5;

            Console.WriteLine($"{KB} KB needed");
            Console.WriteLine($"{submit} submissions");
        }
    }
}
