using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var Month = Console.ReadLine();
            var Nights = int.Parse(Console.ReadLine());
            var PriseApPro510 = 65.0;
            var PriseStPro510 = 50.0;
            var PriseApPro69 = 68.70;
            var PriseStPro69 = 75.20;
            var PriseApPro78 = 77.0;
            var PriseStPro78 = 76.0;
            var PriseAp = 1.0;
            var PriseSt = 1.0;

            if (Nights > 14)
            {
                PriseApPro78 *= 0.9;
                PriseApPro69 *= 0.9;
                PriseApPro510 *= 0.9;
                if (Month == "May" || Month == "October")
                {
                    PriseStPro510 *= 0.7;
                }
                else if (Month == "September" || Month == "June")
                {
                    PriseStPro69 *= 0.8;
                }
                
            }
            else if (Nights > 7) 
            {
                
                if (Month == "May" || Month == "October")
                {
                    PriseStPro510 *= 0.95;
                }


            }

            if (Month == "May" || Month == "October") 
            {
                PriseSt = PriseStPro510;
                PriseAp = PriseApPro510;
            }
            else if (Month == "September" || Month == "June")
            {
                PriseSt = PriseStPro69;
                PriseAp = PriseApPro69;
            }
            else if (Month == "July" || Month == "August")
            {
                PriseSt = PriseStPro78;
                PriseAp = PriseApPro78;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", PriseAp * Nights);
            Console.WriteLine("Studio: {0:f2} lv.", PriseSt * Nights);
        }
    }
}
