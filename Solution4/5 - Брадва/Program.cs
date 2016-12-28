using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char a;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', i), new string('-', 2 * n - i - 2));
            }
            int mid = n / 2;
            for (int j = 0; j < mid ; j++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * n), new string('-', n - 1), new string('-', n - 1));
            }
            for (int j = 0; j < mid ; j++)
            {
                if (j != mid - 1)
                {
                    a = '-';
                }
                else
                {
                    a = '*';
                }
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - j), new string(a, n + 2 * j - 1), new string('-', n - 1 - j));
            }
            
        }
    }
}
