using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistik
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = int.Parse(Console.ReadLine());
            double price = 0;
            double heavy = 0;
            double medium = 0;
            double light = 0;
            double totalWeight = 0;
            double totalPrice = 0;

            for (int i = 0; i < count; i++)
            {
                double weight = double.Parse(Console.ReadLine());
                if (weight >= 12)
                {
                    price = 120 * weight;
                    heavy+=weight;
                }
                else if (weight < 12 && weight >= 4)
                {
                    price = 175 * weight;
                    medium+=weight;
                }
                else if (weight < 4)
                {
                    price = 200 * weight;
                    light+=weight;
                }

                totalWeight += weight;
                totalPrice += price;
            }

            double heavyPercentage = (heavy / totalWeight) * 100;
            double mediumPercentage = (medium / totalWeight) * 100;
            double lightPercentage = (light / totalWeight) * 100;
            double priveAverage = totalPrice / totalWeight;
            Console.WriteLine($"{priveAverage:f2}");
            Console.WriteLine($"{lightPercentage:f2}%");
            Console.WriteLine($"{mediumPercentage:f2}%");
            Console.WriteLine($"{heavyPercentage:f2}%");

        }
    }
}
