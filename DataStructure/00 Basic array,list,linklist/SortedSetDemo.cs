using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /*The Average time complexity of all the above operations on a binary search 
    tree is O(logn), the case when the tree is balanced. The worst-case time 
    complexity is O(n) when the tree is not balanced. */

    /*SortedSet:- Count(),Clear(),Add(T),Contains(T),Remove(T)*/
    /*There are few binary search tree, which always keeps themselves 
balanced. Most important among them are Red-Black Tree (RB-Tree) and 
AVL tree. Ordered dictionary in collections is implemented using RB-Tree*/

    class SortedSetDemo
    {
        public static void Main()
        {
            /*TreeSet is implemented using a binary search tree so add, remove, 
                and contains methods have logarithmic time complexity O(log(n)), where n 
                is the number of elements in the set.*/
            SortedSet<string> ss = new SortedSet<string>();

            ss.Add("India");
            ss.Add("USA");
            ss.Add("Brazil");
            ss.Add("Canada");

            foreach (string item in ss)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
