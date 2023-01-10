//  How you can sort an array in C# without using the Array.Sort method:

using System;

namespace DataStructure
{
    class sortarray
    {
        static void Main(string[] args)
        {
            // Initialize an integer array
            int[] arr = { 4, 5, 2, 1, 3 };

            // Sort the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // Print the sorted array
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
        }
    }
}

/* This code uses a nested loop to compare each element in the array with every 
other element and swaps them if they are out of order. This implementation is known
 as a bubble sort.*/