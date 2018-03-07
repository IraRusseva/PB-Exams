using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_17Sep17
{
    class BirthDay
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volume1 = volume * 0.001;
            double sand = percentage * 0.01;

            double total = volume1 * (1 - sand);

            Console.WriteLine($"{total:f3}");

        }
    }
}
