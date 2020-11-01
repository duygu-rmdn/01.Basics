using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());
            examMinutes += examHour * 60;
            arriveMinutes += arriveHour * 60;

            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                int diff = arriveMinutes - examMinutes;
                if (diff<=60)
                {
                    Console.WriteLine($"{diff:d2} minutes after the start");
                }
                else
                {
                    int h = diff / 60;
                    int m = diff % 60;
                    Console.WriteLine($"{h}:{m:d2} hours after the start");
                }
            }
            else if (arriveMinutes<examMinutes - 30)
            {
                Console.WriteLine("Early");
                if (arriveMinutes > examMinutes)
                {
                    Console.WriteLine("Late");
                    int diff =  examMinutes - arriveMinutes;
                    if (diff <= 60)
                    {
                        Console.WriteLine($"{diff:d2} minutes before the start");
                    }
                    else
                    {
                        int h = diff / 60;
                        int m = diff % 60;
                        Console.WriteLine($"{h}:{m:d2} hours before the start");
                    }
                }
            }
            else
            {
                Console.WriteLine("On time");
            }


        }
    }
}
