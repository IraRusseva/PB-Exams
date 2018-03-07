using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_20Nov16_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double shellsKg = double.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice * 1.60;
            double safridPrice = cacaPrice * 1.80;
            double shellsPrice = 7.50;

            double bill = (palamudKg * palamudPrice) + (safridKg * safridPrice) + (shellsKg * shellsPrice);

            Console.WriteLine($"{bill:f2}");

        }
    }
}
