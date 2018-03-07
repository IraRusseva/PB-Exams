using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfJourney = double.Parse(Console.ReadLine());
            int countOfPuzzles = int.Parse(Console.ReadLine());
            int countOfDolls = int.Parse(Console.ReadLine());
            int countOfBears = int.Parse(Console.ReadLine());
            int countOfMinions = int.Parse(Console.ReadLine());
            int countOfTrucks = int.Parse(Console.ReadLine());

            double priceOfPuzzles = 2.60 * countOfPuzzles;
            double priceOfDolls = 3 * countOfDolls;
            double priceOfBears = 4.10 * countOfBears;
            double priceOfMinions = 8.20 * countOfMinions;
            double priceOfTrucks = 2 *countOfTrucks;

            int countTotal = countOfPuzzles + countOfDolls + countOfBears + countOfMinions + countOfTrucks;
            double profit = (priceOfPuzzles + priceOfDolls + priceOfBears + priceOfMinions + priceOfTrucks) * 0.9;

            if (countTotal > 50)
            {
                profit *= 0.75;
            }

            if (priceOfJourney <= profit)
            {
                double moneyLeft = profit - priceOfJourney;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceOfJourney - profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
