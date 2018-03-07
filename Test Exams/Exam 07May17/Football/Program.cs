using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double allFans = double.Parse(Console.ReadLine());

            double fansSectorA = 0;
            double fansSectorB = 0;
            double fansSectorV = 0;
            double fansSectorG = 0;

            for (int i = 0; i < allFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    fansSectorA += 1;
                }
                else if (sector == "B")
                {
                    fansSectorB += 1;
                }
                else if (sector == "V")
                {
                    fansSectorV += 1;
                }
                else if (sector == "G")
                {
                    fansSectorG += 1;
                }
            }
            double percentageA = (fansSectorA / allFans) * 100;
            double percentageB = (fansSectorB / allFans) * 100;
            double percentageV = (fansSectorV / allFans) * 100;
            double percentageG = (fansSectorG / allFans) * 100;
            double percentageAllFans = (allFans / stadiumCapacity) * 100;

            Console.WriteLine($"{percentageA:f2}%");
            Console.WriteLine($"{percentageB:f2}%");
            Console.WriteLine($"{percentageV:f2}%");
            Console.WriteLine($"{percentageG:f2}%");
            Console.WriteLine($"{percentageAllFans:f2}%");
        }
    }
}
