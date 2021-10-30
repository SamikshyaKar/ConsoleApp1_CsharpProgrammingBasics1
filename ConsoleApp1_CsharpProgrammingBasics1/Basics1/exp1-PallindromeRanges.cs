using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
    public class exp1_PallindromeRanges
    {
        public static void DisplayRangePallindrome()
        {
            Console.WriteLine(" Please Enter a Range of Two numbers ");
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int rev = 0;
            int rem = 0;
            

            for(int num=low; num<=high; num++)
            {
                int OriginalNumber = num;

                while(OriginalNumber !=0)
                {
                     rem = OriginalNumber % 10;
                    rev = rev*10 + rem;
                    OriginalNumber = OriginalNumber / 10;
                }
                if(rev==num)
                {
                    Console.WriteLine("       PALLINDROME  " +num);
                }
                else
                {
                    Console.WriteLine(" NOT PALLINDROME " + num);
                }

                rev = 0;
                rem = 0;
                
            }

        }
    }
}
