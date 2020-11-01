using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string input = Console.ReadLine();
            double num = double.Parse(input);
            double hours = num * 3;
            Console.WriteLine("The architect" + " " + name + " " + "will need " + hours + " hours to complete " + num + " project/s" + ".");

        }
    }
}
