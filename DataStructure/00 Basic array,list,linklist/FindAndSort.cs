using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class FindAndSort
    {
        public static void Main()
        {
            List<int> a =new List<int> { 1, 2, 0, 5, 0, 8, 0, 6 };
            Console.WriteLine(a.Count);

            List<int> b=new List<int>();

            foreach (int val in a)
            {
                if (val==0)
                {
                    b.Add(val);
                  
                }
                
            }
            
                
            foreach (int value in b)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine();
            a.Sort();
            foreach (int value in a)
            {
                Console.Write(value + " ");
            }



            Console.ReadKey();
        }


    }
}
