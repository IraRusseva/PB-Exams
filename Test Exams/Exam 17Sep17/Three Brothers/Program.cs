using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherFishing = double.Parse(Console.ReadLine());

            double fatherFishingMinutes = fatherFishing * 60;
            double cleaningTime = 1/(1/firstBrother + 1/secondBrother + 1/thirdBrother);
            double restTime = cleaningTime * 0.15;
            
            double allBrothersTime = cleaningTime + restTime;
            //double allBrothersTimeMinutes = cleaningTime % 60;

            Console.WriteLine($"Cleaning time: {allBrothersTime:f2}");
            if (allBrothersTime < fatherFishing)
            {
                double hoursLeft = Math.Floor(fatherFishing - allBrothersTime);
                Console.WriteLine($"Yes, there is a surprise - time left -> {hoursLeft} hours.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(allBrothersTime - fatherFishing);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeNeeded} hours.");
            }
        }
    }
}
