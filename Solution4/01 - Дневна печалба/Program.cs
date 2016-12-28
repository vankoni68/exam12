using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var WorkDays = int.Parse(Console.ReadLine());
            var MoneyDays = double.Parse(Console.ReadLine());
            var Curs = double.Parse(Console.ReadLine());

            var AllMoney = WorkDays * MoneyDays * 14.5 * 0.75 * Curs / 365 ;

            Console.WriteLine("{0:f2}", AllMoney);
        }
    }
}
