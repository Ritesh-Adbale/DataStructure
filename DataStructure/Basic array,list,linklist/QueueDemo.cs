using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure     
{
    class QueueDemo
    {
        /*A queue is a First-In-First-Out (FIFO) kind of data structure.
         Queue has the following application uses: 
            1. Access to shared resources (e.g., printer)
            2. Multiprogramming
            3. Message queue
            4. BFS, breadth first traversal of graph or tree are implemented using
            queue.
        Queue:- Count(),Clear(),Dequeue(),Enqueue(),Peek();
         
         */
        public static void Main()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);

            int size = que.Count();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Dequeue from the Queue: "+que.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
