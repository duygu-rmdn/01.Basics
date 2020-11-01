using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            //whatch the lectires and corect tne mistaks
            int storse = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string type = "";
            for (int row = 1; row < storse; row++)
            {
                for (int col = 0; col < rooms; col++)
                {
                    if(row == storse)
                    {
                        type = "L";
                    }
                    else
                    {
                        
                        if (row % 2 == 0)
                        {
                            type = "O";
                        }
                        else
                        {
                            type = "A";
                        }
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
