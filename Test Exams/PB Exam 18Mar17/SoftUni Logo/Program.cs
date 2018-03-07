using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int height = (4 * size) - 2;
            int widht = (12 * size) - 5;
            int countOfDots = widht / 2;
            int countOfHashtag = 1;
            //string dots = new string('.', countOfDots);
            //string hashTags = new string('#', countOfHashtag);


            for (int i = 1; i <=  size * 2; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('.', countOfDots), new string('#', countOfHashtag));

                countOfDots = countOfDots - 3;
                countOfHashtag = countOfHashtag + 6;
            }
            double lowPart = (height - ((size * 2))) - size;
            countOfDots = 3;
            countOfHashtag = widht - 6;

            for (int j = 1; j <= lowPart ; j++)
            {
                Console.Write("|");
                Console.WriteLine("{0}{1}{2}",new string('.', countOfDots - 1), new string('#', countOfHashtag ), new string('.', countOfDots ));

                countOfDots += 3;
                countOfHashtag -= 6;

            }
            for (int z = 1; z < size; z++)
            {
                countOfHashtag = (size * 6) + 1;
                countOfDots = (widht - countOfHashtag) / 2;

                Console.Write("|");
               Console.WriteLine("{0}{1}{2}", new string('.', countOfDots - 1), new string('#', countOfHashtag), new string('.', countOfDots));
            }
            countOfHashtag = (size * 6) + 1;
            countOfDots = (widht - countOfHashtag) / 2;


            Console.Write("@");
            Console.WriteLine("{0}{1}{2}", new string('.', countOfDots - 1), new string('#', countOfHashtag), new string('.', countOfDots));

        }
    }
}
