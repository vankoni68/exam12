using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var HoursNeed = int.Parse(Console.ReadLine());
            var Days = int.Parse(Console.ReadLine());
            var WorkersOut = int.Parse(Console.ReadLine());

            double hours = Days * (0.9 * 8 + 2 * WorkersOut);
            int Diff = (int)hours -  HoursNeed;
            if (Diff < 0)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(Diff));
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.", Diff);
            }
        }
    }
}
