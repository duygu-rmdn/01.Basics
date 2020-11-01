using System;

namespace ReadNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalgartes = 0;
            int classgount = 0;
             
            while ( classgount< 12)
            {
                double grate = double.Parse(Console.ReadLine());

                if (grate < 4.00)
                {
                    continue;
                }
                else
                {
                    classgount++;
                    totalgartes += grate;
                }
            }
            double av = totalgartes / classgount;
            Console.WriteLine($"{ name} graduated. Average grade: {av:f2} ");
           
        }
    }
}
