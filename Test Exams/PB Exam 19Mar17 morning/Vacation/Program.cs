using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string accomodation = string.Empty;
            string location = string.Empty;
            double price = 0;

            if (season == "summer")
            {
                location = "Alaska";

                if (budget > 3000)
                {
                    accomodation = "Hotel";
                    price = budget * 0.9;
                }
                else if (budget <= 3000 && budget > 1000)
                {
                    accomodation = "Hut";
                    price = budget * 0.8;
                }
                else if (budget <= 1000)
                {
                    accomodation = "Camp";
                    price = budget * 0.65;
                }
            }
            if (season == "winter")
            {
                location = "Morocco";

                if (budget > 3000)
                {
                    accomodation = "Hotel";
                    price = budget * 0.9;
                }
                else if (budget <= 3000 && budget > 1000)
                {
                    accomodation = "Hut";
                    price = budget * 0.6;
                }
                else if (budget <= 1000)
                {
                    accomodation = "Camp";
                    price = budget * 0.45;
                }
            }
            Console.WriteLine($"{location} - {accomodation} - {price:f2}");

        }
    }
}
