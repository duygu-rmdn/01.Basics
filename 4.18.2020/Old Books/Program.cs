using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int booksCount = int.Parse(Console.ReadLine());
            int checkedCound = 0;
            bool isFount = false;
            while (!isFount)
            {
                string currBook = Console.ReadLine();
                if (currBook == book)
                {
                    isFount = true;
                }
                else
                {
                    checkedCound++;
                    if (checkedCound >= booksCount)
                    {
                        break;
                    }
                }
            }
            if (isFount)
            {
                Console.WriteLine($"You checked {checkedCound} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked { booksCount} books.");
            }
        }
    }
}
