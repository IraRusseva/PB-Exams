using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lyutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatos = double.Parse(Console.ReadLine());
            int cases = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());

            double totalLyutenitsa = (tomatos / 5);
            double fullJars = totalLyutenitsa / 0.535;
            double fullCases = fullJars / jars;
            int totalJarsPerTruck = cases * jars;

            Console.WriteLine($"Total lutenica: {Math.Floor(totalLyutenitsa):f0} kilograms.");

            if (fullCases >= cases)
            {
                double casesLeft = Math.Floor(fullCases - cases);
                double jarsLetf = Math.Floor(fullJars - totalJarsPerTruck);
                Console.WriteLine($"{casesLeft} boxes left.");
                Console.WriteLine($"{jarsLetf} jars left.");
            }
            else
            {
                double casesNeeded = Math.Floor(cases - fullCases);
                double jarsNeeded = Math.Floor(totalJarsPerTruck - fullJars);
                Console.WriteLine($"{casesNeeded} more boxes needed.");
                Console.WriteLine($"{jarsNeeded} more jars needed.");
            }
        }
    }
}
