using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    // C# program sort array in even and odd manner. 6 1 2 3 4 5 6
    // The odd numbers are to be sorted in Ascending(left to right)
    // order and the even numbers in dscending order(right to left)
    class OddEvenSorting
    {
        // To do two way sort. First sort odd numbers in
        // ascending order, then odd numbers in descending
        // order.
        static void twoWaySort(int[] arr, int n)
        {
            // Current indexes from left to right
            int left = 0,right = n-1;
            // Count of odd numbers
            //int k = 0;

            while (left<right)
            {
                // Find first odd number
                // from left side.
                while (arr[left]%2!=0 && left < right)
                {
                    left++;
                    //k++;
                }
                // Find first even number from right side.
                while (arr[right]%2==0 && left < right)
                {
                    right--;
                    //k++;
                }
                // Swap even number present
                // on left and odd
                // number right.
                if (left < right)
                {
                    // swap arr[l] arr[r]
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    //left++;
                    //right--;
                }
            }
            //Array.Sort(arr,0,k); //ascending odd
            //Array.Reverse(arr, k, 0); //descending even
            //Array.Sort(arr, k, n - k);
            // Sort odd number in descending order (even)
            //Array.Sort(arr, 0, k);
            //Array.Reverse(arr, 0, k);
            // Sort even number in ascending order
            //Array.Sort(arr, k, n - k);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), artemp => Convert.ToInt32(artemp));

            twoWaySort(arr, arr.Length);
            Console.WriteLine(String.Join(" ",arr));
        }

    }
}
