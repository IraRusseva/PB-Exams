using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styropor
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseVolume = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double styroporVolume = double.Parse(Console.ReadLine());
            double styroporPrice = double.Parse(Console.ReadLine());

            double windowsVolume = windowsCount * 2.4;

            double styropor = (houseVolume - windowsVolume) / styroporVolume;
            double styroporNeeded = Math.Ceiling(styropor * 1.1);
            double totalPrice = styroporNeeded * styroporPrice;

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Spent: {totalPrice:f2}");
                Console.WriteLine($"Left: {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Need more: {moneyNeeded:f2}");
            }
        }
    }
}
