using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_07May17
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double priceOfRakia = priceOfWiskey * 0.5;
            double priceOfWine = priceOfRakia * 0.6;
            double priceOfBeer = priceOfRakia * 0.2;

            double priceOfRakiaTotal = priceOfRakia * rakia;
            double priceOfWineTotal = priceOfWine * wine;
            double priceOfBeerTotal = priceOfBeer * beer;
            double priceOfWiskeyTotal = priceOfWiskey * wiskey;

            double total = priceOfWiskeyTotal + priceOfRakiaTotal + priceOfWineTotal + priceOfBeerTotal;
            
            Console.WriteLine($"{total:f2}");

             
        }
    }
}
