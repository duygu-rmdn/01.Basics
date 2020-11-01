using System;

namespace ds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sl = int.Parse(Console.ReadLine());
            int zw = int.Parse(Console.ReadLine());
            int str = int.Parse(Console.ReadLine());

            if (sl >= 80)
            {
                if (zw >= 80)
                {
                    if (str >= 8)
                    {
                        Console.WriteLine("Legacy");
                    }
                }
                else if (zw<=10)
                {
                    Console.WriteLine("Master");
                }
            }
            if (sl <=30 && sl >10)
            {
                if (str <=1)
                {
                    Console.WriteLine("Eazy");
                }


            }
            else if(sl <=10)
            {
                Console.WriteLine("Elementary");
            }
            if (sl < 80 && sl>30)
            {
                if (zw >= 50)
                {
                    if (str >= 2)
                    {
                        Console.WriteLine("Hard");
                    }
                }
                else
                {
                    Console.WriteLine("Regular");
                }
            }
        }
    }
}
