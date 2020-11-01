using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {

                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'o':
                        sum += 3;
                        break;
                    case 'u':
                        sum += 4;
                        break;
                }

                Console.WriteLine(sum);
            }
           

        }
    }
}
