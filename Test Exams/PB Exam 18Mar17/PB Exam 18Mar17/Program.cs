using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_18Mar17
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double wallsHeight = A / 2;
            //double triangleHeight = B - (A / 2);

            double paintSideWalls = ((A * wallsHeight) * 2);
            double backWallPaint = (wallsHeight * wallsHeight);
            double triangleArea = (A/2 * (B- A/2))/2;
            double frontWallPaint = (backWallPaint+ triangleArea) - ((A / 5) *( A/5));

            double greenPaint = (paintSideWalls + backWallPaint + frontWallPaint + triangleArea) / 3;

            double rooftop = (A * wallsHeight) * 2;
            double redPaint = rooftop / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
