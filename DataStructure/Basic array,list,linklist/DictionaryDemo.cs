using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class DictionaryDemo
    {
        /*A Dictionary<> is a data structure that maps keys to values. A Dictionary<> 
            is an implementation of IDictionary<> and is implemented using a hash 
            table so the "key value pairs are not stored in sorted order." Dictionary<> 
            "does not allow duplicate keys buts values can be duplicate." 
        */
        public static void Main()
        {
            Dictionary<string, int> dn = new Dictionary<string, int>();

            dn["William"] = 90;
            dn["Alexander"] = 90;
            dn["William"] = 90;
            dn["Emma"] = 65;

            foreach (string key in dn.Keys)
            {
                Console.WriteLine(key+"Score marks : "+dn[key]);
            }

            Console.WriteLine("Emma Present in the Class: "+dn.ContainsKey("Emma"));
            Console.WriteLine("John Present in the Class: "+dn.ContainsKey("John"));

            dn.Remove("Emma");
            Console.WriteLine("Emma Present in the Class: " + dn.ContainsKey("Emma"));

            Console.ReadKey();
        }
    }
}
