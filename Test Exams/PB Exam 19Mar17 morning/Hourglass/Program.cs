using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int widthAndHeight = 2 * size + 1;
            string asteriks = new string('*', widthAndHeight);

            Console.WriteLine(asteriks);

            int countOfWhiteSpaces = widthAndHeight - 4;
            string whiteSpace = new string(' ', countOfWhiteSpaces);
            int countOfDots = 1;
            string dots = new string('.', countOfDots);
            string secondRow = dots + "*" + whiteSpace + "*" + dots;
            Console.WriteLine(secondRow);
            for (int i = 0; i < size-2; i++)
            {
                countOfDots++;
                countOfWhiteSpaces--;
                string at = new string('@', countOfWhiteSpaces);

                Console.WriteLine("{0}*{1}*{0}", dots, at);
            }

            Console.WriteLine(asteriks);
        }
    }
}
