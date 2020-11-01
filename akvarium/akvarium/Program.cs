using System;

namespace akvarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volume = lenght * width * heigth;
            double liters = volume * 0.001;
            double sand = liters * percentage / 100;
            double remaining = liters - sand;

            Console.WriteLine($"{remaining:f3}");
        }
    }
}
