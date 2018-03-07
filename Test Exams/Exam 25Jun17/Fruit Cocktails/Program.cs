using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine().ToLower();
            int orderedDrinks = int.Parse(Console.ReadLine());

            double bill = 0.0;

            if (size == "small")
                if (fruit == "watermelon")
                {
                    bill = orderedDrinks * 56 * 2;
                }
                else if (fruit == "mango")
                {
                    bill = orderedDrinks * 36.66* 2;
                }
                else if (fruit == "pineapple")
                {
                    bill = orderedDrinks * 42.10 * 2;
                }
                else
                {
                    bill = orderedDrinks * 20 * 2;
                }


            if (size == "big")
            {
                if (fruit == "watermelon")
                {
                    bill = orderedDrinks * 28.70 * 5;
                }
                else if (fruit == "mango")
                {
                    bill = orderedDrinks * 19.60 * 5;
                }
                else if (fruit == "pineapple")
                {
                    bill = orderedDrinks * 24.80 * 5;
                }
                else
                {
                    bill = orderedDrinks * 15.20 * 5;
                }
            }
            if (bill > 1000)
            {
                bill *= 0.5;
            }
            else if (bill >= 400 && bill <= 1000)
            {
                bill *= 0.85;

            }

            Console.WriteLine($"{bill:f2} lv.");
        }
    }
}
