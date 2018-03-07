using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Award
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double awardPerPoints = double.Parse(Console.ReadLine());
            double sumPointsEven = 0.0;
            double sumPointsOdd = 0.0;

            for (int i = 1; i <= parts; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (i % 2==0)
                {
                    sumPointsEven += readNumber * 2;
                }
                else
                {
                    sumPointsOdd += readNumber;
                }
            }
            double projectPrize = (sumPointsEven + sumPointsOdd) * awardPerPoints;
            Console.WriteLine($"The project prize was {projectPrize:f2} lv.");
        }
    }
}
