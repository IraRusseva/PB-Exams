using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_25Jun17
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumFromCakes = bakers * cakes * 45;
            double sumFromWaffles = bakers * waffles * 5.80;
            double sumFromPancakes = bakers * pancakes * 3.20;
            double total = (sumFromCakes + sumFromPancakes + sumFromWaffles) * days;
            double sumForProducts =  total/ 1 / 8;
            double charity = total - sumForProducts;

            Console.WriteLine($"{charity:f2}");
        }
    }
}
