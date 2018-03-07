using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_19Mar17
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());
            double kgPerSqMeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grapeTotal = (sqMeters * kgPerSqMeter) - waste;
            double grapeForRakia = ((grapeTotal * 45) / 100)/7.5;
            double grapeForSale = (grapeTotal * 55) / 100;

            double profitRakia = grapeForRakia * 9.80;
            double profitGrapes = grapeForSale * 1.50;

            Console.WriteLine($"{profitRakia:f2}");
            Console.WriteLine($"{profitGrapes:f2}");


        }
    }
}
