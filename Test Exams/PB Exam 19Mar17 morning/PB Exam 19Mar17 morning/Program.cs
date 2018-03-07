using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_19Mar17_morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightOfHouse = double.Parse(Console.ReadLine());
            double widthOfWall = double.Parse(Console.ReadLine());
            double heigthOfRoof = double.Parse(Console.ReadLine());

            double houseVolumeFrontAndBack = ((heightOfHouse * heightOfHouse) * 2) - 2.4 ;
            double houseVolumeSideWalls = ((heightOfHouse * widthOfWall) * 2) - 4.5;
            double roofVolumeSide = heightOfHouse * widthOfWall * 2;
            double roofVolumeFrontAndBack = ((heightOfHouse * heigthOfRoof)/ 2) * 2;

            double greenPaint = (houseVolumeFrontAndBack + houseVolumeSideWalls) / 3.4;
            double redPaint = (roofVolumeFrontAndBack + roofVolumeSide) / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
