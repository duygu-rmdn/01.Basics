using System;

namespace tradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
          double sales = double.Parse(Console.ReadLine();
            bool isValid = true;
            double commission = -1.0;

            if (town == "Sofia")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales > 10000)
                {
                    commission = 0.12;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }
            if (town == "Varna")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.10;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }
            if (town == "Plovdiv")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }


            if (isValid)
            {
                Console.WriteLine("{0:f2}", sales * commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
