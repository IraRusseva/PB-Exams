using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string group = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double pricePerStudent = 0.0;
            double price = 0;

            if (season == "winter")
            {
                if (group == "boys")
                {
                    pricePerStudent = nights * 9.6;
                    sport = "Judo";
                }
                else if (group == "girls")
                {
                    pricePerStudent = nights * 9.60;
                    sport = "Gymnastics";
                }
                else if (group == "mixed")
                {
                    pricePerStudent = nights * 10;
                    sport = "Ski";
                }
            }
            else if (season == "spring")
            {
                if (group == "boys")
                {
                    pricePerStudent = 7.20 * nights;
                    sport = "Tennis";
                }
                else if (group == "girls")
                {
                    pricePerStudent = 7.20 * nights;
                    sport = "Athletics";
                }
                else if (group == "mixed")
                {
                    pricePerStudent = 9.50 * nights;
                    sport = "Cycling";
                }
            }
            else if (season == "summer")
            {
                if (group == "boys")
                {
                    pricePerStudent = 15 * nights;
                    sport = "Football";
                }
                else if (group == "girls")
                {
                    pricePerStudent = 15 * nights;
                    sport = "Volleyball";
                }
                else if (group == "mixed")
                {
                    pricePerStudent = 20 * nights;
                    sport = "Swimming";
                }
            }
            if (students >= 50)
            {
                price = (pricePerStudent * students) * 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                price = (pricePerStudent * students) * 0.85;
            }
            else if (students >= 10 && students < 20)
            {
                price = (pricePerStudent * students) * 0.95;
            }
            else
            {
                price = pricePerStudent * students;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
