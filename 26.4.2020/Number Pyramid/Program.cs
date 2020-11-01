using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int row = 1;
            int currNum = 1;
            bool isEqua = false;
            while ( isEqua = false)
            {
                for (int i  = 1; i  <= row ; i ++)
                {
                    Console.Write(currNum + " ");
                    currNum++;

                    if (currNum >= targetNum)
                    {
                        isEqua = true;
                        break;
                    }
                }
                row++;
                Console.WriteLine();
            }




        }
    }
}
