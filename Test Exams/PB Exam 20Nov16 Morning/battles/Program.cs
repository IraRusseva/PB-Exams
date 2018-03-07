using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int countOfBattles = 0;

            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int j = 1; j <= secondPlayer; j++)
                {
                    countOfBattles++;
                    Console.Write($"({i} <-> {j}) ");
                    if (countOfBattles == battles)
                    {
                        return;
                    }
                }
            }
        }
    }
}
