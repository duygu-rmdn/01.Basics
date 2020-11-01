using System;

class Program
{
    static void Main()
    {
        double studio = 0;
        double apartment = 0;
        double discount = 0;

        string month = Console.ReadLine();
        double nights = double.Parse(Console.ReadLine());

        if (month == "May" || month == "October")
        {
            studio = 50;
            apartment = 65;
        }
        else if (month == "June" || month == "September")
        {
            studio = 75.2;
            apartment = 68.7;
        }
        else if (month == "July" || month == "August")
        {
            studio = 76;
            apartment = 77;
        }

        if (nights > 7 && nights <= 14 && (month == "May" || month == "October"))
        {
            discount = studio * 0.05;
            studio -= discount;
        }
        if (nights > 14 && (month == "May" || month == "October"))
        {
            discount = studio * 0.3;
            studio -= discount;
        }
        if (nights > 14 && (month == "June" || month == "September"))
        {
            discount = studio * 0.2;
            studio -= discount;
        }
        if (nights > 14)
        {
            discount = apartment * 0.1;
            apartment -= discount;
        }

        studio *= nights;
        apartment *= nights;

        Console.WriteLine("Apartment: {0:F2} lv.", apartment);
        Console.WriteLine("Studio: {0:F2} lv.", studio);
    }
}