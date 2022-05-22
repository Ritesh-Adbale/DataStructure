using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkListDemo
    {
        /*Linked lists are dynamic data structure and memory is allocated at run time. 
            The concept of linked list is not to store data contiguously. Nodes of linked 
            list contains link that point to the next elements in the list.
        
            Performance wise linked lists are slower than arrays because there is no 
            direct access to linked list elements.
        
            Linked list is a useful data structure when we do not know the number of elements to be stored ahead of time. 
            There are many types of linked list: linear, circular, doubly, doubly circular 
            etc   
        Linklist API:- Insert(k),Delete(),PrintList(),Find(k),FindKth(k),IsEmpty()
        LinkList properties and methods:-  AddFirst(T),AddLast(T),Clear(),Find(T),Remove(T),RemoveFirst(),RemoveLast();
        */

        public static void Main()
        {
            LinkedList<int> ll = new LinkedList<int>();

            //ll.AddFirst(10);
            //ll.AddLast(20);
            //ll.AddFirst(9);
            //ll.AddLast(21);
            //ll.AddFirst(8);
            //ll.AddLast(22);

            Console.Write("Content of Linked List: ");
            foreach (int val in ll)
            {
                Console.Write(val+" ");
            }

            //ll.Remove(10);

            ll.RemoveFirst();
            ll.RemoveLast();
            
            Console.Write("\nContent of Linked List: ");
            foreach (int val in ll)
            {
                Console.Write(val + " ");
            }
            Console.ReadKey();
        }


    }
}
