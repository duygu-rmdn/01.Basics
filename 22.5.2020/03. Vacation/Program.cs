using System;
using System.Xml.Schema;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
                if (count >= 30)
                {
                    price *= 0.85;
                }
            }
            if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
                if (count >= 100)
                {
                    count -= 10;
                }
            }
            if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                if (count >= 10 && count <= 20)
                {
                    price *= 0.95;
                }
            }
            double totalPrice = count * price;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
