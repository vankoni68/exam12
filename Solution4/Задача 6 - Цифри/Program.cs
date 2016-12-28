using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int dig3 = num % 10;
            int dig2 = (num / 10);
            dig2 = dig2 % 10;
            int dig1 = num / 100;
            var n = dig1 + dig2;
            var m = dig1 + dig3;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (num % 5 == 0)
                    {
                        num = num - dig1;
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - dig2;
                    }
                    else
                    {
                        num = num + dig3;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine("");
            }
           
        }
    }
}
