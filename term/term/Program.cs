using System;

namespace term
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Your program is:");
                    Console.WriteLine("9:00-9:30 Biology");
                    Console.WriteLine("9:40-10:10 History");
                    Console.WriteLine("10:20-10:50 English");
                    Console.WriteLine("11:00-11:30 Geography");
                    Console.WriteLine("11:40-12:10 English");
                    Console.WriteLine("12:20-12:50 English");
                    Console.WriteLine("13:00-13:30 Bulgarian");
                    break;
                case "Tuesday":
                    Console.WriteLine("Your program is:");
                    Console.WriteLine("9:00-9:30 Math");
                    Console.WriteLine("9:40-10:10 Math");
                    Console.WriteLine("10:20-10:50 English");
                    Console.WriteLine("11:00-11:30 Sport");
                    Console.WriteLine("11:40-12:10 English");
                    Console.WriteLine("12:20-12:50 English");
                    Console.WriteLine("13:00-13:30 English");
                    break;
                case "Wednesday":
                    Console.WriteLine("Your program is:");
                    Console.WriteLine("9:00-9:30 Bulgarian");
                    Console.WriteLine("9:40-10:10 Philosophy");
                    Console.WriteLine("10:20-10:50 Art");
                    Console.WriteLine("11:00-11:30 IT");
                    Console.WriteLine("11:40-12:10 English");
                    Console.WriteLine("12:20-12:50 English");
                    Console.WriteLine("13:00-13:30 English");
                    break;
                case "Thursday":
                    Console.WriteLine("Your program is:");
                    Console.WriteLine("9:00-9:30 English");
                    Console.WriteLine("9:40-10:10 English");
                    Console.WriteLine("10:20-10:50 Bulgarian");
                    Console.WriteLine("11:00-11:30 Sport");
                    Console.WriteLine("11:40-12:10 Chemistry");
                    Console.WriteLine("12:20-12:50 Phiciks");
                    Console.WriteLine("13:00-13:30 Math");
                    Console.WriteLine("13:40-14:10 Math");
                    break;
                case "Friday":
                    Console.WriteLine("Your program is:");
                    Console.WriteLine("9:00-9:30 Bulgarian");
                    Console.WriteLine("9:40-10:10 MAth");
                    Console.WriteLine("10:20-10:50 English");
                    Console.WriteLine("11:00-11:30 English");
                    Console.WriteLine("11:40-12:10 History");
                    Console.WriteLine("12:20-12:50 Biology");
                    Console.WriteLine("13:00-13:30 Entrepreneurship");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Today you are not doing online studying, but don't forget for lectures!");
                    break;

            }
            Console.WriteLine("Have a nice day and enjoy!");
        }
    }
}
