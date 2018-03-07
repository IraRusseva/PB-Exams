using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_18Dec16
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedAtStart = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double firstTimeInHours = firstTime / 60;
            double secondTimeInHours = secondTime / 60;
            double thirdTimeInHours = thirdTime / 60;

            double kmOnFirstSpeed = speedAtStart * firstTimeInHours;
            double kmOnSecondSpeed = (speedAtStart * 1.10) * secondTimeInHours;
            double secondSpeed = speedAtStart * 1.10;
            double kmOnThirdSpeed = (secondSpeed * 0.95) * thirdTimeInHours;

            double kmTotal = kmOnFirstSpeed + kmOnSecondSpeed + kmOnThirdSpeed;

            Console.WriteLine($"{kmTotal:f2}");
        }
    }
}
