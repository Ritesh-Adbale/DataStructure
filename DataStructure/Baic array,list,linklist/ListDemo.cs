using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class ListDemo
    {
        /*List<T> in C# Collections is a data structure which implements IList<T> 
            interface which means that it can have duplicate elements in it. List is an 
            implementation as dynamic array that can grow or shrink as needed. 
            (Internally array is used when it is full a bigger array is allocated and the old 
            array values are copied to it.)
            
        List<T> class Properties and methods:- Count,Item[index],Add,Clear,Remove(T),RemoveAt(index),Reverse()
         */


        public static void Main()
        {
            List<int> al = new List<int>();

            al.Add(1); //add 1 to the end of the list
            al.Add(2); //add 2 to the end of the list
            al.Add(3); //add 3 to the end of the list
            al.Add(4); //add 4 to the end of the list

            Console.Write("Contents of List after adding 1,2,3,4: ");
            al.ForEach(Console.Write);

            Console.WriteLine("\nContents of List at index 0: " + al[0]);

            Console.WriteLine("List Size: " + al.Count); //Print size of List

            Console.WriteLine("List IsEmpty: " + (al.Count == 0));

            al.RemoveAt(al.Count - 1); //last element of List is removed

            Console.WriteLine("\nList Size after element removed: " + al.Count);

            al.Clear();//all the elements of List are removed.

            Console.WriteLine("List IsEmpty after clear: " + (al.Count == 0));

            Console.ReadKey();
        }
    }
}
