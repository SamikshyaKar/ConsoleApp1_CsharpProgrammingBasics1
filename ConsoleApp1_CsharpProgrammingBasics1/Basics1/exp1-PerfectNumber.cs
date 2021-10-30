using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
    public class exp1_PerfectNumber
    {
        public static void Display_Perfect()
        {
            Console.WriteLine(" Enter a number ");
            int num = int.Parse(Console.ReadLine());
            int rem = 0;
            int sum = 0;

           for(int i=1; i<num;i++ )
            {
                rem = num % i;
                if(rem==0)
                {
                    sum = sum + i;
                }
            }
           if(sum==num)
            {
                Console.WriteLine(" The Number is PERFECT " + num);
            }
           else
            {
                Console.WriteLine(" NUMBER NOT PERFECT " );
            }
        }
    }
}
