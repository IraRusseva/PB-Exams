using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double timeTotal = distanceInMeters * timePerMeter;
            double slowTime = Math.Floor(distanceInMeters / 15) * 12.5;
            double timeFinal = timeTotal + slowTime;
            if (timeFinal < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeFinal:f2} seconds.");
            }
            else
            {
                double timeNeeded = timeFinal - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
