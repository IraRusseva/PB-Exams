using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05Nov17
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaWidth = double.Parse(Console.ReadLine());
            double areaLenght = double.Parse(Console.ReadLine());
            double netHeight = double.Parse(Console.ReadLine());
            double netPrice = double.Parse(Console.ReadLine());
            double netWieght = double.Parse(Console.ReadLine());

            double totalNet = (areaLenght * 2) + (areaWidth * 2);
            double totalNetPrice = totalNet * netPrice;
            double netArea = totalNet * netHeight;
            double totalNetWeight = (netArea * netWieght);


            Console.WriteLine(totalNet);
            Console.WriteLine($"{totalNetPrice:f2}");
            Console.WriteLine($"{totalNetWeight:f3}");
        }
    }
}
