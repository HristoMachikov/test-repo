using System;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var Buget = decimal.Parse(Console.ReadLine());
            var Season = Console.ReadLine();

            var Place = "";
            var CampOrHotel = "";
            var Rate = 0.0m;

            if (Buget <= 100)
            {
                Place = "Bulgaria";
                if (Season == "summer")
                {
                    CampOrHotel = "Camp";
                    Rate = 30;
                }
                else if (Season == "winter")
                {
                    CampOrHotel = "Hotel";
                    Rate = 70;
                }
            }
            else if (Buget > 100 && Buget <= 1000)
            {
                Place = "Balkans";
                if (Season == "summer")
                {
                    CampOrHotel = "Camp";
                    Rate = 40;
                }
                else
                {
                    CampOrHotel = "Hotel";
                    Rate = 80;
                }
            }
            else if (Buget > 1000)
            {
                Place = "Europe";
                CampOrHotel = "Hotel";
                Rate = 90;
            }
            var SpentMoney = Rate / 100 * Buget;
            Console.WriteLine("Somewhere in {0}", Place);
            Console.WriteLine("{0} - {1:f2}", CampOrHotel, SpentMoney);
        }
    }
}
