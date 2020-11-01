using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classground = 0;
            double totalMark = 0.0;
            int excludedCount = 0;
            bool isexpeld = false;
            while (classground < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark >= 4.00)
                {
                    
                    classground++;
                    totalMark += mark;
                }
                else
                {
                    
                    excludedCount++;
                    if (excludedCount > 1)
                    {
                        isexpeld = true;
                        break;
                    }
                }
            }
            if (isexpeld)
            {

                Console.WriteLine($"{name} has been excluded at {classground+1} grade");
            }
            else
            {
 double averange = totalMark / classground;

                Console.WriteLine($"{name} graduated. Average grade: {averange:f2} ");
            }
        }
    }
}
