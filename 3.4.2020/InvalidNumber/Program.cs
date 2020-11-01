using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            bool isValid = num == 0 || ( num >= 100 && num <= 200);
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
