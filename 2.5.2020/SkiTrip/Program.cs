using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string feedback = Console.ReadLine();
            double prise = 0;
            if (type == "room for one person")
            {
                prise = 18.00;
            }
            else if (type == "apartment")
            {
                prise = 25.00;
            }
            else
            {
                prise = 35.00;
            }

            switch (type)
            {
                case "apartment":
                    break;
                    case "president apartment";
                    break;
                //undersood


            }
        }
    }
}
