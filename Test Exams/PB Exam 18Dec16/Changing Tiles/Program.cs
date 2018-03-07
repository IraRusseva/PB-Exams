using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySaved = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double sideOfTile = double.Parse(Console.ReadLine());
            double heightOfTile = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double priceForWork = double.Parse(Console.ReadLine());

            double tileArea = (sideOfTile * heightOfTile) / 2;
            double floorArea = floorLenght * floorWidth;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;

            double finalPrice = (tilesNeeded * pricePerTile) + priceForWork;
            if (finalPrice <= moneySaved)
            {
                double moneyLeft = moneySaved - finalPrice;
                Console.WriteLine($"{moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = finalPrice - moneySaved;
                Console.WriteLine($"You'll need {moneyNeeded:f2} lv more.");
            }


        }
    }
}
