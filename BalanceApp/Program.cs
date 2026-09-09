using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{

    class Program
    {
        static void Main()
        {
            var b1 = new Balance(125.50m);
            var b2 = new Balance(-50.75m);
            var b3 = new Balance(0);

            Console.WriteLine(b1 > b2);   // True
            Console.WriteLine(b2 < b3);   // True
            Console.WriteLine(b1 >= b3);  // True
            Console.WriteLine(b2 <= b3);  // True

            Console.WriteLine(b1 == new Balance(125.50m));  // True
            Console.WriteLine(b1 != b2);                    // True

            if (b1) Console.WriteLine("b1 положительный");
            if (b2) Console.WriteLine("b2 положительный");
            if (b3) Console.WriteLine("b3 положительный");

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}
