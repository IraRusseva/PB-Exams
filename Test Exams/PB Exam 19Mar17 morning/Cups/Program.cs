using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCups = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int countOfDays = int.Parse(Console.ReadLine());

            double workingTime = countOfWorkers * countOfDays * 8;
            double cups = Math.Floor(workingTime / 5);

            if (cups >= countOfCups)
            {
                double moneyExtra = (cups - countOfCups) * 4.20;
                Console.WriteLine($"{moneyExtra:f2} extra money");
            }
            else
            {
                double moneyLess = (countOfCups - cups) * 4.20;
                Console.WriteLine($"Losses: {moneyLess:f2}");
            }

        }
    }
}
