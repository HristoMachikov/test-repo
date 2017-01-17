using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Buterfly
{
    class Buterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine(@"{0}\ /{0}",
                        new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}\ /{0}",
                        new string('-', n - 2));
                }
            }
            Console.WriteLine("{0}@{0}",
                new string(' ', n - 1));
            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine(@"{0}/ \{0}",
                        new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(@"{0}/ \{0}",
                        new string('-', n - 2));
                }
            }
        }
    }
}
