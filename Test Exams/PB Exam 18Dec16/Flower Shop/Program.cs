using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)

        {
            double countOfChirsantems = double.Parse(Console.ReadLine());
            double countOfRoses = double.Parse(Console.ReadLine());
            double countOfTulips = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double priceOfChrisantems = 0;
            double priceOfRoses = 0;
            double priceOfTulips = 0;
            double priceForBouquet = 0; 
            double discountForFlower = 0;
            double discountForBouquet = 0;

            if (season == "summer" || season == "spring")
            {
                priceOfChrisantems = 2.00;
                priceOfRoses = 4.10;
                priceOfTulips = 2.50;
                if (season == "spring" && countOfTulips >= 7)
                {
                    discountForFlower = priceForBouquet * 0.05;
                }

            }

            else if (season == "winter" || season == "autumn")
            {
                priceOfChrisantems = 3.75;
                priceOfRoses = 4.50;
                priceOfTulips = 2.15;
                if (season == "winter" && countOfRoses >= 10)
                {
                    discountForFlower = priceForBouquet * 0.10;
                }
            }
            if (countOfRoses + countOfChirsantems + countOfTulips >= 20)
            {
                discountForBouquet = priceForBouquet * 0.20;
            }
            priceForBouquet = priceOfChrisantems * countOfChirsantems + priceOfRoses * countOfRoses + priceOfTulips * countOfTulips;

            if (holiday == "y")
            {
                priceForBouquet *= 1.15;
            }

            double priceTotal = priceForBouquet - (discountForFlower+ discountForBouquet);
            Console.WriteLine($"{priceTotal:f2}");
        }
    }
}
