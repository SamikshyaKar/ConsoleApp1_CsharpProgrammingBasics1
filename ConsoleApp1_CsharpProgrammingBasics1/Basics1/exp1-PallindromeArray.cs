using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
    public class exp1_PallindromeArray
    {
        public static void Display_Pallindrome_Array()
        {
            Console.WriteLine(" Enter the legth of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int flag = 0;
            for(int counter=0; counter<n; counter++)
            {
                arr[counter] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();

            for (int i = 0; i <= n / 2 && n != 0; i++)
            {

                // Check if first and last element are different 
                // Then set flag to 1. 
                if (arr[i] != arr[n - i - 1])
                {
                    flag = 1;
                    break;
                }
            }

            // If flag is set then print Not Palindrome 
            // else print Palindrome. 
            if (flag == 1)
                Console.WriteLine("Not Palindrome");
            else
                Console.WriteLine("Palindrome");

            Console.WriteLine((flag == 1) ? " NOT_ PALLINDROME " : " _PALLINDROME");
            string RESULT = (flag == 1) ? " NOT_ PALLINDROME " : " _PALLINDROME";
            Console.WriteLine("         RESULT is " +RESULT);
        }
    }
}
