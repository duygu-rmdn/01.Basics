using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
             int classground = 0;
            double totalMark = 0.0;
            while(classground < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark < 4.00)
                {
                    continue;
                }
                else
                {
                    classground++;
                    totalMark += mark;
                }
            }
            double averange= totalMark / classground;

            Console.WriteLine($"{name} graduated. Average grade: {averange:f2} ");
        }
    }
}
