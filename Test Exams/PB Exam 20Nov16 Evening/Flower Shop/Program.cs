using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMagnolia = int.Parse(Console.ReadLine());
            int countOfzyumbul = int.Parse(Console.ReadLine());
            int countOfRosees = int.Parse(Console.ReadLine());
            int countOfCactus = int.Parse(Console.ReadLine());
            double priceOfToy = double.Parse(Console.ReadLine());

            double income = (countOfMagnolia * 3.25) + (countOfzyumbul * 4)
                + (countOfRosees * 3.50) + (countOfCactus * 8);
            double incomeAfterTaxes = income * 0.95;

            if (incomeAfterTaxes >= priceOfToy)
            {
                double moneyLeft = Math.Floor(incomeAfterTaxes - priceOfToy);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyNotEnough = Math.Ceiling(priceOfToy - incomeAfterTaxes);
                Console.WriteLine($"She will have to borrow {moneyNotEnough} leva.");
            }
            
        }
    }
}
