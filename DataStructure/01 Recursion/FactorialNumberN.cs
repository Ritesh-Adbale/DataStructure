using System;

namespace DataStructure
{
    // Factorial
    // n! = n * (n-1) * (n-2) * (n-3)….* 1
    // 3!=3*2*1=6
    public class FactorialNumberN 
    {
        static int func(int n)
        {
            if (n == 0)
                return 1;
            int partialans = func(n - 1); //Copy of function is keep in memory
            // Console.WriteLine("n"+n);
            // Console.WriteLine("p"+partialans);
            return n*partialans;

        }
       public static void Main()
       {
            Console.Write("Enter a number for Factorial :- ");
        //Accept enter number here.
           int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
        //if number is smaller than zero    
            if(number<=0)
            {
                Console.Write("Error: Enter number Greater than Zero");
            }else{

            Console.WriteLine(func(number));
            }
            Console.ReadKey();
       }
    }
}
/*
    time complexity : O(n)
    space complexity : O(n)
*/