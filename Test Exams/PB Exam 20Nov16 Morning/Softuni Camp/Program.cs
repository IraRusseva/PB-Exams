using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfGroups = int.Parse(Console.ReadLine());
            double car = 0;
            double van = 0;
            double smallBus = 0;
            double bus = 0;
            double train = 0;
            double allPassengers = 0;

            for (int i = 0; i < countOfGroups; i++)
            {
                double groupMembers = int.Parse(Console.ReadLine());
                if (groupMembers >= 41)
                {
                    train += groupMembers;
                }
                else if (groupMembers <41 && groupMembers >= 26)
                {
                    bus += groupMembers;
                }
                else if (groupMembers < 26 && groupMembers >= 13)
                {
                    smallBus += groupMembers;
                }
                else if (groupMembers < 13 && groupMembers >= 6)
                {
                    van += groupMembers;
                }
                else if (groupMembers < 6)
                {
                    car += groupMembers;
                }
                allPassengers += groupMembers;
            }
            double carPercent = (car / allPassengers) * 100;
            double vanPercent = (van / allPassengers) * 100;
            double smallBusPercent = (smallBus / allPassengers) * 100;
            double busPercent = (bus / allPassengers) * 100;
            double trainPercent = (train / allPassengers) * 100;

            Console.WriteLine($"{carPercent:f2}%");
            Console.WriteLine($"{vanPercent:f2}%");
            Console.WriteLine($"{smallBusPercent:f2}%");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
