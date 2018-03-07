using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double quantity = 0.0;
            double degrees = 0.0;
            double degreesAverage = 0.0;

            for (int i = 0; i < days; i++)
            {
                double quantityPerDay = double.Parse(Console.ReadLine());
                double degreesPerDay = double.Parse(Console.ReadLine());
                
                quantity += quantityPerDay;
                degrees += degreesPerDay;
                degreesAverage += quantityPerDay * degreesPerDay;

            }
            degreesAverage /= quantity;
            Console.WriteLine($"Liter: {quantity:f2}");
            Console.WriteLine($"Degrees: {degreesAverage:f2}");
            if (degreesAverage < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            if (degreesAverage >= 38 && degreesAverage <=42)
            {
                Console.WriteLine("Super!");
            }
            if (degreesAverage > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
