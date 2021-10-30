using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
   public  class exp1_Pallindrome
    {
        public static void Display_Pallindrome()
        {
            Console.WriteLine(" Enter a number ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            int Number = num;

            while(num !=0)
            {
                int rem = num % 10;
                rev = rev*10 + rem;
                num = num / 10;
            }
            if(rev==Number)
            {
                Console.WriteLine("                    Number Pallindrome   "   + Number);
            }
            else
            {
                Console.WriteLine(" Not Pallindrome   " +Number);
            }
        }

    }
}
