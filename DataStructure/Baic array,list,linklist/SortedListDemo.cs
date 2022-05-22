using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SortedListDemo
    {
        /*A SortedList<T> is a data structure that maps keys to values. 
        A SortedList <T> is an implementation of IDictionary<T> and is implemented using a
            sorted array so the key-value pairs are stored in sorted order. SortedList
            <T> does not allow duplicate keys buts values can be duplicate. Since
            key/value pairs are stored in a sorted array, so key based searching is
            performed using binary search.
        SortedList<T> class:- Count,Item[key],Add(key,value),Clear();ContainsKey(),Remove(key);

         */
        public static void Main()
        {
            SortedList<string, int> tm = new SortedList<string, int>();
            tm["William"] = 99;
            tm["Alexander"] = 80;
            tm["Michael"] = 50;
            tm["Michael"] = 60;
            tm["Emma"] = 65;
           

            Console.WriteLine("Total number of students in class:: " + tm.Count); 

            foreach (string key in tm.Keys)
            {
                Console.WriteLine(key + " Score Marks : " + tm[key]); // key means here string i.e. "Alexander" ; tm[Alexander]
            }

            Console.WriteLine("Emma present in class:: "+tm.ContainsKey("Emma")); //Check whether Emma in list or not return  True or false
            Console.WriteLine("John present in class:: "+tm.ContainsKey("John")); //Check whether John in list or not return  True or false

            tm.Remove(("Emma"));    //Remove Emma from the list 

            Console.WriteLine("Emma present in class:: "+tm.ContainsKey("Emma")); //Check whether Emma in list or not return  True or false
            Console.ReadKey();
        }
    }
}
