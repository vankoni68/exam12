using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var PatAll = 0;
            var PattPr = 0;
            var ProDay = 7;

            for (int i = 1; i <= n; i++)
            {
                if ( i % 3 == 0 && (PatAll - PattPr) > PattPr)
                {
                    ProDay++;
                }
                var d = int.Parse(Console.ReadLine());
                PatAll += d;
                if (d < ProDay)
                {
                    PattPr += d;
                }
                else
                {
                    PattPr += ProDay;
                }
            }
            Console.WriteLine("Treated patients: {0}.", PattPr);
            Console.WriteLine("Untreated patients: {0}.", PatAll - PattPr);
        }
    }
}
