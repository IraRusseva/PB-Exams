using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = 4 * size + 4;
            int width = 3 * size + 1;

            int countOfwaves = size - 2;
            string waves = new string('~', countOfwaves);
            int countOfDots = 2 * size + 1;
            string dots = new string('.', countOfDots);

            Console.WriteLine("+{0}+{1}", waves,dots);
            countOfDots--;
            Console.WriteLine("|\\{0}\\{1}", waves, dots);
            int countOfFirstDots = 1;
            string firstDots = new string('.', countOfFirstDots);
            for (int i = 0; i < (2 * size)-1; i++)
            {
                countOfDots--;
                Console.WriteLine($"|{firstDots}\\{waves}\\{dots}");
                countOfFirstDots++;
            }


        }
    }
}
