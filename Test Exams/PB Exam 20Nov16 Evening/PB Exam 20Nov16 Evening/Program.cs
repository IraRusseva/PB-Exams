using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Exam_20Nov16_Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSq = double.Parse(Console.ReadLine());

            double bathroomArea = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea * 1.10;
            double thirdRoomArea = secondRoomArea * 1.10;

            double allRoomsArea = smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea;
            double totalArea = allRoomsArea * 1.05;

            double price = totalArea * pricePerSq;

            Console.WriteLine($"{price:f2}");
        }
    }
}
