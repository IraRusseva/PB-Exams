using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAdults = int.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfNights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double ticketsPrice = 0;
            double ticketsPerStudents = 0;
            //double allTickets = 0;
            double hotelPrice = countOfNights * 82.99;

            if (transport == "train")
            {
                ticketsPrice = 24.99 * countOfAdults;
                ticketsPerStudents = 14.99 * countOfStudents;
                if (countOfAdults + countOfStudents >= 50)
                {
                    ticketsPrice *= 0.5;
                    ticketsPerStudents *= 0.5;
                }
            }
            else if (transport == "bus")
            {
                ticketsPrice = 32.50 * countOfAdults;
                ticketsPerStudents = 28.50 * countOfStudents;
            }
            else if (transport == "boat")
            {
                ticketsPrice = 42.99 * countOfAdults;
                ticketsPerStudents = 39.99 * countOfStudents;
            }
            else if (transport == "airplane")
            {
                ticketsPrice = 70.0 * countOfAdults;
                ticketsPerStudents = 50 * countOfStudents;
            }

            double totaPriceWOComission = ((ticketsPrice + ticketsPerStudents)* 2) + hotelPrice;
            double comission = totaPriceWOComission * 0.10;
            double final = totaPriceWOComission + comission;
            Console.WriteLine($"{final:f2}");
        }
    }
}
