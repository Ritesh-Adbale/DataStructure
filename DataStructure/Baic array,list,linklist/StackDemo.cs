using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackDemo
    {
        /*Stack is a special kind of data structure that follows Last-In-First-Out (LIFO) 
        strategy.
        The various applications of stack are: 
        1. Recursion: recursive calls are implemented using system stack.
        2. Postfix evaluation of expression.
        3. Backtracking implemented using stack.
        4. Depth-first search of trees and graphs.
        5. Converting a decimal number into a binary number etc
        Stack:- Count(),Clear(),Pop(),Push(T),Peek().
         */
        /*NOTE:- O(1) Time Complexity. */
        public static void Main()
        {
            Stack<int> stk = new Stack<int>();

            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4);

            Console.WriteLine("Element of the top of the Stack is: "+stk.Peek());

            int size=stk.Count;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Pop from stack: "+stk.Pop());
            }

            Console.ReadKey();
        }
    }
}
