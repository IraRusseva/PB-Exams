using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclists
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();

            //double taxJuniors = 0;
            //double taxSeniors = 0;
            double income = 0;

            if (type == "trail")
            {
                income = ((juniors * 5.50) + (seniors * 7)) * 0.95;
            }
            else if (type == "cross-country")
            {

                if (juniors + seniors >= 50)
                {
                    income = ((juniors * (8 * 0.75)) + (seniors * (9.50 * 0.75))) * 0.95;
                }
                else
                income = ((juniors * 8) + (seniors * 9.50)) * 0.95;
            }
            else if (type == "downhill")
            {
                income = ((juniors * 12.25) + (seniors * 13.75)) * 0.95;

            }
            else if (type == "road")
            {
                income = ((juniors * 20) + (seniors * 21.50)) * 0.95;

            }
            Console.WriteLine($"{income:f2}");
        }
    }
}
