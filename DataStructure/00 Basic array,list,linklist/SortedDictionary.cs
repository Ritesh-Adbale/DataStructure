using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SortedDictionary
    {
        /*Implemented using red-black balanced binary search tree so the key value 
pairs are stored in sorted order. */
        public static void Main()
        {
            SortedDictionary<string,int> tm= new SortedDictionary<string, int>();

            tm["William"] = 99;
            tm["Alexander"] = 80;
            tm["Michael"] = 50;
            tm["Emma"] = 65;

            Console.WriteLine("Total number of students in class:: "+tm.Count);
            foreach (string key in tm.Keys)
            {
                Console.WriteLine(key+" Score Marks : "+tm[key]);
            }

            Console.WriteLine("Emma present in class:: "+tm.ContainsKey("Emma")); // return in true or false
            Console.WriteLine("John present in class:: " + tm.ContainsKey("John"));// return in true or false

            tm.Remove("Emma"); //Removing Emma

            Console.WriteLine("Emma present in class:: " + tm.ContainsKey("Emma"));
            Console.ReadKey();
        }
    }
}
