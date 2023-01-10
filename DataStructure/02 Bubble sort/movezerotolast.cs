using System;

namespace DataStructure
{
    class movezerotolast
    {
        static void Main(string[] args)
        {
            // Initialize the array with zeros mixed in with other numbers
            int[] arr = { 4, 0, 5, 0, 2, 1, 3 };

            // Keep track of the number of zeros found
            int numZeros = 0;

            // Loop through the array and count the number of zeros
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    numZeros++;
                }
            }

            // Loop through the array again and move all non-zero elements to the front
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }

            // Add the zeros to the end of the array
            while (numZeros > 0)
            {
                arr[index] = 0;
                index++;
                numZeros--;
            }

            // Print the resulting array
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
        }
    }
}
