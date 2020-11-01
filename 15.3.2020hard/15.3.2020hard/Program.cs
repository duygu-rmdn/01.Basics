using System;

namespace _15._3._2020hard
{
    class Program
    {
        static void Main(string[] args)
        {
            double tClothPrice = 7;
            double squarePrice = 9;

            int tableCount = int.Parse(Console.ReadLine());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double clothSize = (length + 0.6) * (width + 0.6);
            double squareSize = (length / 2) * (length / 2);
            double totalPrice = tableCount * clothSize * 7 + tableCount * squareSize * 9;
            Console.WriteLine($"{totalPrice:f2} USD");
            Console.WriteLine("{totalPrice*1.85:f2}");
        }
    }
}
