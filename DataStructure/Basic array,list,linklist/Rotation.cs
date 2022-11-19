using System;

namespace DataStructure
{
    class Rotation
    {
        static void leftRotate(int[] arr,int d, int n)
        {
            for (int i = 0; i < d; i++)
            {
                leftRotatebyOne(arr,n);
            }
        }

        static void leftRotatebyOne(int[]arr,int n)
        {
            int i, temp = arr[0];
            for ( i = 0; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
                
            }
            arr[n - 1] = temp;
        }

        static void printArray(int[]arr,int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);
            }
            leftRotate(arr, 2, 7);
            printArray(arr, 7);
            Console.ReadKey();
        }
    }
}
