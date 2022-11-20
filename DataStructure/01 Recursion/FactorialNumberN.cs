using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class FactorialNumberN
    {
        static int func(int n)
        {
            if (n == 0)
                return 1;
            int partialans = func(n - 1);
            Console.WriteLine("n"+n);
            Console.WriteLine("p"+partialans);
            return n*partialans;

        }
       public static void Main()
       {
            Console.WriteLine(func(3));
            Console.ReadKey();
       }
    }
}
