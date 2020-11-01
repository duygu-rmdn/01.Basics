using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            if (days > 0 )
            days = -1;
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;

            if (roomType == "room for one person")
            {
                price = 18;

            }
            else if (roomType=="apartmant")
            {


            }
            else
            {

            }



                    switch(roomType)
                {
                case "prezident aparment"
                    if (days <=10)
                    {
                        price = price * 0.90;
                    }
                    else if (days <=15)
                    {
                        price *= 0.85;
                    }
            }
        }
    }
}
