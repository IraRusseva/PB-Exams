using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petc
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForDogKG = double.Parse(Console.ReadLine());
            double foodForCatKg = double.Parse(Console.ReadLine());
            double foodForTurtleGr = double.Parse(Console.ReadLine());

            double foodForTurtleKg = foodForTurtleGr / 1000;

            double foodNeeded = (foodForDogKG * days) + (foodForCatKg * days) + (foodForTurtleKg * days);

            if (food >= foodNeeded)
            {
                double kgLeft = Math.Floor(food - foodNeeded);
                Console.WriteLine($"{kgLeft} kilos of food left.");
            }
            else
            {
                double kgNeeded = Math.Ceiling(foodNeeded - food);
                Console.WriteLine($"{kgNeeded} more kilos of food are needed.");
            }
        }
    }
}
