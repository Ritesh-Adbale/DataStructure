using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class HashSetDemo
    {
        /*A Hash-Table is a data structure that maps keys to values. Each position of 
        the Hash-Table is called a slot. The Hash-Table uses a hash function to 
        calculate an index of data in an array. We use the Hash-Table when the 
        number of key-value pair actually stored are small relatively to the number 
        of possible keys.*/
        public static void Main()
        {
            HashSet<string> hs = new HashSet<string>();

            hs.Add("India");
            hs.Add("USA");
            hs.Add("Brazil");
            hs.Add("Canada");

            foreach (string  str in hs)
            {
                Console.Write(str+" ");
            }

            Console.WriteLine("Hash Table contains USA: "+hs.Contains("USA"));
            Console.WriteLine("Hash Table contains Russia: "+hs.Contains("Russia"));

            hs.Remove("USA");
            Console.WriteLine("Hash Table contains USA: " + hs.Contains("USA"));

            Console.ReadKey();
        }
    }
}
